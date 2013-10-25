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
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_love').click());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Love", "=)");
            }
            SubmitRate();
        }

        private void RateSongDown()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_hate').click());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Hate", "=(");
            }
            SubmitRate();
        }

        private void SubmitRate()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementsByName('commit')[0].click());");
        }


        private void ReloadBrowser()
        {
            JangoBrowser.Reload();
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
            if (_track != null)
            {
                CheckSong();
            }
        }

        private void JangoBrowserDocumentCompleted(object sender, EventArgs e)
        {

            //Reset the track when the page has finished loading, this will be triggered if users launch any links on the page.
            if (JangoBrowser.Window.Frames.Count <= 0) return;

            //Get the frame jango is running in
            var jangoFrame = JangoBrowser.Window.Frames[1].Document;

            if (jangoFrame.GetElementById("current-song").InnerHtml != null)
            {
                _track = new Track(JangoBrowser.Window.Frames[1].Document);
            }

            //Submit a vote/rate if need be
            if (JangoBrowser.Window.Frames[1].Document.GetElementsByName("commit").Count > 0)
            {
                SubmitRate();
            }
        }
    }
}
