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
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_love').onclick());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Love", "=)");
            }
        }

        private void RateSongDown()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_hate').onclick());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Hate", "=(");
            }
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

            if (this.Visible)
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
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideJangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleJangoDesktop();
        }

        private void ShowLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://jango.com/players/lyrics");
        }
        
        //Context Menu Items
        private void GreatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RateSongUp();
        }

        private void BadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RateSongDown();
        }

        private void DisplayCurrentSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParseSong(true);
        }

        private void NextTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextTrack();
        }

        private void PlayPauseSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayPause();
        }
        #endregion

        private void CheckSong()
        {
            if (_tempSong != _track.Song)
            {
                _tempSong = _track.Song;
                ParseSong(Settings.Default.DisplaySongBalloon);
            }

            if (_track.TimeRemaining.EndsWith("0:10"))
                ParseSong(Settings.Default.DisplaySongBalloonAtEndOfSong);

            _notifyIcon.Text = _track.ToString();

        }

        private void ParseSong(bool displayBalloonTip)
        {
            if (displayBalloonTip)
            {
                ShowBalloonTip(_track.Artist, _track.Song + " " + _track.TimeRemaining);
            }
            CopyToClipBoardToolStripMenuItem1.Enabled = true;

        }

        private void ShowBalloonTip(string title, string message)
        {
            _notifyIcon.ShowBalloonTip(100, title, message, System.Windows.Forms.ToolTipIcon.None);
        }

        private void aboutJangoDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsDialog settingsDialog = new SettingsDialog();
            settingsDialog.ShowDialog();
        }

        private void CopyToClipBoardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_track.Artist + " " + _track.Song);
        }

        private void JangoBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            //Usually when the Title changes the song has changed, so check to see if we need to parse songs.
            if (JangoBrowser.Window.Frames.Count > 0 && _track == null)
                _track = new Track(JangoBrowser.Window.Frames[1].Document);
        }

        private void SongUpdater_Tick(object sender, EventArgs e)
        {
            if (_track != null)
                CheckSong();
        }
    }
}
