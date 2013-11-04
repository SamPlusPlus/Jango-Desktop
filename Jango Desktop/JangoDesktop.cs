/*
 * Copyright (C) 2010 Samuel Haddad, 
 * and individual contributors.
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 3
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */


using System;
using System.Windows.Forms;
using Skybound.Gecko;
using gma.System.Windows;
using Jango_Desktop.Properties;
using Jango_Desktop.Utilities;


namespace Jango_Desktop
{


    public partial class JangoDesktop : Form
    {
        UserActivityHook _actHook;
        private String _tempSong = null;
        private Track _track;
        private bool _starting = true;
        private bool _pageNeedsParsing = true; //Should be true if it hasn't loaded or has changed
        private bool _injectedJs;
        private bool _ratingSent;

        public JangoDesktop()
        {
            InitializeComponent();
        }

        #region Keyboard Hooks
        //Keyboard Hooks
        public void MyKeyDown(object sender, KeyEventArgs e)
        {
            //Play Pause
            if (e.KeyCode.Equals(Keys.MediaStop) || e.KeyCode.Equals(Keys.MediaPlayPause) || e.KeyData.Equals(Settings.Default.KeyboardPlayPause))
                PlayPause();

            //Next Track
            else if (e.KeyCode.Equals(Keys.MediaNextTrack) || e.KeyData.Equals(Settings.Default.KeyboardNextTrack))
                NextTrack();

            //Rate up
            else if (e.KeyData.Equals(Settings.Default.KeyboardRateUp))
                RateSongUp();

            //Rate Down
            else if (e.KeyData.Equals(Settings.Default.KeyboardRateDown))
                RateSongDown();

            //DisplayToolTip
            else if (e.KeyData.Equals(Settings.Default.KeyboardDisplaySong))
                ParseSong(true);

            else if (e.KeyData.Equals(Settings.Default.KeyboardRefresh))
                ReloadBrowser();
        }
        #endregion

        #region Actions
        //Action Calls

        private void NextTrack()
        {
            JangoBrowser.Navigate("javascript:void(_jp.ctrls.onSkip());");

        }

        private void PlayPause()
        {
            JangoBrowser.Navigate("javascript:void(_jp.ctrls.onPlayPause())");
        }

        private void RateSongUp()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('btn-fav').click());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Love", "=)");
            }
            _ratingSent = true;
           
        }

        private void RateSongDown()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_ban').click());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Hate", "=(");
            }
            _ratingSent = true;
        }

        private void SubmitRate()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementsByName('commit')[0].click());");
        }


        private void ReloadBrowser()
        {
            JangoBrowser.Reload();
            _injectedJs = false;
        }
        

      
        #endregion

        #region Setup Jango Desktop

        private void JangoDesktopLoad(object sender, EventArgs e)
        {
            if (!Settings.Default.StartMinimized)
            {
                ToggleJangoDesktop();
            }
            if (Settings.Default.AutoLogin)
            {
                //AutoLogin is turned on
                string decryptedUsername = AESEncryption.Decrypt(Settings.Default.JangoUsername, Environment.MachineName + Environment.ProcessorCount, Environment.UserName, "SHA1", Environment.ProcessorCount, "16CHARSLONG12345", 256);
                string decryptedPassword = AESEncryption.Decrypt(Settings.Default.JangoPassword, Environment.MachineName + Environment.ProcessorCount, Environment.UserName, "SHA1", Environment.ProcessorCount, "16CHARSLONG12345", 256);
                JangoBrowser.Navigate("http://www.jango.com/splogin?user[email]=" + decryptedUsername + "&user[password]=" + decryptedPassword);
            }
            else
            {
                JangoBrowser.Navigate("http://www.jango.com");
            }

            //Start Keyboard Hook
            try
            {
                _actHook = new UserActivityHook();
                _actHook.KeyDown += new KeyEventHandler(MyKeyDown);
                _actHook.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Error setting up media keys. They will not work. Try restarting Jango Desktop");
            }

            _starting = false;
        }
        #endregion

        #region Jango Desktop Load

        private void JangoDesktop_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && !_starting )
                ToggleJangoDesktop();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ToggleJangoDesktop();
        }

        private void ToggleJangoDesktop()
        {

            if (this.Visible && !_starting)
            {
                this.Visible = false;
                hideJangoToolStripMenuItem.Text = "Show Jango Desktop";
            }
            else
            {
                hideJangoToolStripMenuItem.Text = "Hide Jango Desktop";
                this.TopMost = true;
                this.BringToFront();
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
                this.TopMost = false;
            }

        }
        #endregion


        #region Context Menu Items
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideJangoToolStripMenuItemClick(object sender, EventArgs e)
        {
            ToggleJangoDesktop();
        }

        //Context Menu Items
        private void GreatToolStripMenuItemClick(object sender, EventArgs e)
        {
            RateSongUp();
        }

        private void BadToolStripMenuItemClick(object sender, EventArgs e)
        {
            RateSongDown();
        }

        private void DisplayCurrentSongToolStripMenuItemClick(object sender, EventArgs e)
        {
            ParseSong(true);
        }

        private void NextTrackToolStripMenuItemClick(object sender, EventArgs e)
        {
            NextTrack();
        }

        private void PlayPauseSongToolStripMenuItemClick(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReloadBrowser();
        }

        #endregion

        private void CheckSong()
        {
            if (_track.Song == null) return;

            if (_tempSong != _track.Song)
            {
                _tempSong = _track.Song;
                ParseSong(Settings.Default.DisplaySongBalloon);
            }

            if (_track.TimeRemaining.EndsWith("0:10"))
                ParseSong(Settings.Default.DisplaySongBalloonAtEndOfSong);

            string trackSong = _track.ToString();

            _notifyIcon.Text = trackSong.Length > 63 ? trackSong.Substring(0, 62) : trackSong;

        }

        private void ParseSong(bool displayBalloonTip)
        {
            if (displayBalloonTip)
            {
                ShowBalloonTip(_track.Song, _track.Artist + " " + _track.TimeRemaining);
            }
            CopyToClipBoardToolStripMenuItem1.Enabled = true;

        }

        private void ShowBalloonTip(string title, string message)
        {
            if (!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(message))
            {
                _notifyIcon.ShowBalloonTip(100, title, message, System.Windows.Forms.ToolTipIcon.None);
            }
        }

        private void AboutJangoDesktopToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            SettingsDialog settingsDialog = new SettingsDialog();
            settingsDialog.ShowDialog();
        }

        private void CopyToClipBoardToolStripMenuItemClick(object sender, EventArgs e)
        {
            Clipboard.SetText(_track.Song + " " + _track.Artist);
        }

        private void SongUpdaterTick(object sender, EventArgs e)
        {
            if(_pageNeedsParsing)
            {
                HandlePageChanged();
            }

            //Check if we need to display a title change
            if (_track != null)
            {
                CheckSong();
            }

            if (_ratingSent)
            {
                SubmitRate();
                _ratingSent = false;
            }
        }

        private void HandlePageChanged()
        {
            _track = null;

            //Reset the track when the page has finished loading, this will be triggered if users launch any links on the page.
            if (JangoBrowser.Window.Frames.Count <= 0) return;



            //Get the frame jango is running in
            var jangoFrame = JangoBrowser.Window.Frames[1].Document;

            if (!_injectedJs && jangoFrame.DocumentElement.GetElementsByTagName("body").Count > 0)
            {
                //We are using an older version of Firefox and the XUL runner so we need to define what the click method is.
                //TODO: consider upgrading to a newer version of XUL runner, or anotehr browser control. 
                //It is a shame the built in IE control sucks.
                _injectedJs = true;
                var header = jangoFrame.DocumentElement.GetElementsByTagName("body")[0];
                var injectedFunctions = jangoFrame.CreateElement("script");
                injectedFunctions.TextContent =
                    "HTMLElement.prototype.click = function() { var evt = this.ownerDocument.createEvent('MouseEvents'); evt.initMouseEvent('click', true, true, this.ownerDocument.defaultView, 1, 0, 0, 0, 0, false, false, false, false, 0, null); this.dispatchEvent(evt); } ";
                header.AppendChild(injectedFunctions);
                
            }

            var currentEle = jangoFrame.GetElementById("current-song");

            if (currentEle != null && currentEle.InnerHtml != null)
            {
                _track = new Track(JangoBrowser.Window.Frames[1].Document);
                _pageNeedsParsing = false;
            }

            // Submit a vote/rate if need be
            if (jangoFrame.GetElementsByName("commit").Count > 0)
            {
                SubmitRate();
            }
        }

        private void JangoBrowser_ProgressChanged(object sender, GeckoProgressEventArgs e)
        {
            _pageNeedsParsing = true;
        }
       
    }
}
