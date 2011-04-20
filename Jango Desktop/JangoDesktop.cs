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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using gma.System.Windows;
using System.Threading;
using System.IO;
using Jango_Desktop.Properties;
using Jango_Desktop.Utilities;




namespace Jango_Desktop
{


    public partial class JangoDesktop : Form
    {
        UserActivityHook actHook;
        String tempSong = "";
        String timer, artist, song;
        HtmlDocument hDoc;
        public bool loaded = true;
        public bool cleared = false;

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
                parseSong(true);
        }
        #endregion

        #region Actions
        //Action Calls

        //_jp.ctrls.isPlaying() 
        private void NextTrack()
        {
            JangoBrowser.Navigate("javascript:void(_jp.ctrls.onSkip());");

        }
        public void PlayPause()
        {
            JangoBrowser.Navigate("javascript:void(_jp.ctrls.onPlayPause())");

            //;
           // javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_love').onclick());
        }

        public void RateSongUp()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_love').onclick());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Love", "=)");
            }
        }

        public void RateSongDown()
        {
            JangoBrowser.Navigate("javascript:void(document.getElementsByName('content')[0].contentWindow.document.getElementById('player_hate').onclick());");
            if (Settings.Default.DisplaySongRating)
            {
                ShowBalloonTip("Hate", "=(");
            }
        }

      
        #endregion

        #region Setup Jango Desktop
        //Browser Navigation Methods
        public void NavigateToUrlSync(string url)
        {
            loaded = false;
            JangoBrowser.Navigate(url);
            while (!loaded)
            {
                Application.DoEvents();
            }
        }


        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            loaded = true;

        }

        #region Cache Buster
        private void ClearInternetCacheFolder()
        {
            ClearFolder(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)));
            cleared = true;
        }
        private void ClearFolder(DirectoryInfo directoryInfo)
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {

                try
                {


                    if (file.Name.Contains("soundmanager"))
                    {
                        file.Delete();
                    }
                }
                catch { }
            }
            foreach
                (DirectoryInfo subfolder in directoryInfo.GetDirectories())
            {
                ClearFolder(subfolder);
            }
        }
        #endregion



        private void JangoDesktop_Load(object sender, EventArgs e)
        {
            //Cache Buster
            ClearInternetCacheFolder();
            while (!cleared)
            {
                Application.DoEvents();
            }
            //end cache busting
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
                actHook = new UserActivityHook();
                actHook.KeyDown += new KeyEventHandler(MyKeyDown);
                actHook.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Error setting up media keys. They will not work. Try to restart Jango Desktop");
            }
        }



        private void JangoDesktop_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                toggleJango();
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            toggleJango();
        }

        private void toggleJango()
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
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideJangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleJango();
        }

        private void showLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://jango.com/players/lyrics");
        }
        
        //Context Menu Items
        private void greatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RateSongUp();
        }

        private void badToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RateSongDown();
        }

        private void displayCurrentSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parseSong(true);
        }

        private void nextTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextTrack();
        }

        private void playPauseSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayPause();
        }
        #endregion


        private void songCheckerTimer_Tick(object sender, EventArgs e)
        {
            SongChecker();
        }

        private void SongChecker()
        {
            try
            {
                hDoc = JangoBrowser.Document;
                hDoc = hDoc.Window.Frames[1].Document;
                //If a song changes
                timer = hDoc.GetElementById("timer").InnerText;
                //The current song has changed beginning of a song
                if (tempSong != hDoc.GetElementById("current-song").InnerText)
                {
                    tempSong = hDoc.GetElementById("current-song").InnerText;
                    parseSong(Settings.Default.DisplaySongBalloon);
                }

                //End of a song
                //Display at end of song
                if (timer.EndsWith("0:10"))
                    parseSong(Settings.Default.DisplaySongBalloonAtEndOfSong);

                notifyIcon1.Text = artist + ": " + tempSong + " " + timer;
            }
            catch (Exception) { }
        }

        private void parseSong(bool displayBalloonTip)
        {
            try
            {
                timer = hDoc.GetElementById("timer").InnerText;
                artist = hDoc.GetElementById("player_current_artist").InnerText;
                song = hDoc.GetElementById("current-song").InnerText;
                if (displayBalloonTip)
                {
                    ShowBalloonTip(artist, song + " " + timer);
                }
                CopyToClipBoardToolStripMenuItem1.Enabled = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ShowBalloonTip(string title, string message)
        {
            notifyIcon1.ShowBalloonTip(100, title, message, System.Windows.Forms.ToolTipIcon.None);
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
            Clipboard.SetText(artist + " " + song);
        }
    }
}
