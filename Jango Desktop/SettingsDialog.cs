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
using Jango_Desktop.Properties;
using Jango_Desktop.Utilities;


namespace Jango_Desktop
{
    public partial class SettingsDialog : Form
    {

        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            //Load Player Tab Settings
            displaySongTips.Checked = Settings.Default.DisplaySongBalloon;
            displaySongTipsAtEndOfSongCheckBox.Checked = Settings.Default.DisplaySongBalloonAtEndOfSong;
            displaySongRating.Checked = Settings.Default.DisplaySongRating;
            startMinimized.Checked = Settings.Default.StartMinimized;
            AutoLoginCheckbox.Checked = Settings.Default.AutoLogin;
            jangoUsernameTxtBox.Text = AESEncryption.Decrypt(Settings.Default.JangoUsername, Environment.MachineName + Environment.ProcessorCount, Environment.UserName, "SHA1", Environment.ProcessorCount, "16CHARSLONG12345", 256);
            jangoPasswordTxtBox.Text = AESEncryption.Decrypt(Settings.Default.JangoPassword, Environment.MachineName + Environment.ProcessorCount, Environment.UserName, "SHA1", Environment.ProcessorCount, "16CHARSLONG12345", 256);

            //Load the Keyboard Shortcuts Tab
            PlayPauseLabel.Text = Settings.Default.KeyboardPlayPause.ToString();
            NextTrackLabel.Text = Settings.Default.KeyboardNextTrack.ToString();
            RateupLabel.Text = Settings.Default.KeyboardRateUp.ToString();
            RateDownLabel.Text = Settings.Default.KeyboardRateDown.ToString();
            DisplaySongLabel.Text = Settings.Default.KeyboardDisplaySong.ToString();
        }

        private void settingsSaveBtn_Click(object sender, EventArgs e)
        {
            //Save all the settings
            Settings.Default.DisplaySongBalloon = displaySongTips.Checked;
            Settings.Default.DisplaySongBalloonAtEndOfSong = displaySongTipsAtEndOfSongCheckBox.Checked;
            Settings.Default.DisplaySongRating = displaySongRating.Checked;
            Settings.Default.StartMinimized = startMinimized.Checked;

            //Store Password Encrypted
            //Example    string FinalValue=AESEncryption.Encrypt("My Text","My Password","Salt or Password2","SHA1",2,"16CHARSLONG12345",256);
            string encryptedUsername = AESEncryption.Encrypt(jangoUsernameTxtBox.Text, Environment.MachineName + Environment.ProcessorCount, Environment.UserName,"SHA1",Environment.ProcessorCount,"16CHARSLONG12345",256);
            string encryptedPassword = AESEncryption.Encrypt(jangoPasswordTxtBox.Text, Environment.MachineName + Environment.ProcessorCount, Environment.UserName, "SHA1", Environment.ProcessorCount, "16CHARSLONG12345", 256);
            Settings.Default.JangoUsername = encryptedUsername;
            Settings.Default.JangoPassword = encryptedPassword;
            Settings.Default.AutoLogin = AutoLoginCheckbox.Checked;
               Settings.Default.Save();
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            this.Close();

        }

        private void SecurityRisksLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("When using the auto login feature: \n\nYour username and password are stored in an encrypted format. \nSince it is possible for hackers to reverse encryption, you should not store your username and password on a shared machine, and you should use a password for Jango.com that is separate for any other account.", "Security Risks");

        }

        #region SetShortcutKeys
        private void PlayPauseSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.KeyboardPlayPause = SetShortCut(PlayPauseLabel);
        }

        private void NextTrackSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.KeyboardNextTrack = SetShortCut(NextTrackLabel);
        }

        private void RateUpSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.KeyboardRateUp = SetShortCut(RateupLabel);
        }

        private void RateDownSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.KeyboardRateDown = SetShortCut(RateDownLabel);
        }

        private void DisplaySongSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.KeyboardDisplaySong = SetShortCut(DisplaySongLabel);
        }

        private Keys SetShortCut(Label l)
        {

            KeyCatcher kc = new KeyCatcher();
            if (kc.ShowDialog() == DialogResult.OK)
            {
                l.Text = kc.getShortCut().ToString();
            }

            return kc.getShortCut();

        } 
        #endregion
    }
}
