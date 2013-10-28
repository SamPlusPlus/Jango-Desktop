using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsDragMove;

namespace Jango_Desktop
{
    public partial class MiniPlayer : Form
    {
        private JangoDesktop _mainPlayer;

        public MiniPlayer(JangoDesktop mainJangoPlayer)
        {
            InitializeComponent();
            this.EnableDragMove(true);
            _mainPlayer = mainJangoPlayer;
        }

        private void MiniPlayer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            expandArrowPictureBox.BackgroundImage = Properties.Resources.expand_arrow_over;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            expandArrowPictureBox.BackgroundImage = Properties.Resources.expand_arrow_normal;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        public void Reload()
        {
            Track track = _mainPlayer.Track;

            songLbl.Text = track.Song;
            artistLabel.Text = track.Artist;
            if (!String.IsNullOrEmpty(track.AlbumArtUrl))
            {
                albumArtPictureBox.Load(track.AlbumArtUrl);
            }

            playPauseBtn.Image = track.IsPaused ? Properties.Resources.control_play :Properties.Resources.control_pause;
            timerLabel.Text = track.TimeRemaining;

            timeRemainingProgressBar.Maximum = track.TrackLength;
            timeRemainingProgressBar.Value = Math.Max((track.TrackLength - track.TimeRemainingAtInt), 0);
            timeRemainingProgressBar.Refresh();
        }

        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            TooglePlayPauseBtn();
            _mainPlayer.PlayPause();
        }

        private void TooglePlayPauseBtn()
        {
            Reload();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            _mainPlayer.NextTrack();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            _mainPlayer.ReloadBrowser();
        }

        private void rateUpBtn_Click(object sender, EventArgs e)
        {
            _mainPlayer.RateSongUp();
        }

        private void RateDownBtn_Click(object sender, EventArgs e)
        {
            _mainPlayer.RateSongDown();
        }
    }
}
