namespace Jango_Desktop
{
    partial class MiniPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.expandArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.albumArtPictureBox = new System.Windows.Forms.PictureBox();
            this.songLbl = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playPauseBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.rateUpBtn = new System.Windows.Forms.Button();
            this.RateDownBtn = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timeRemainingProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.expandArrowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // expandArrowPictureBox
            // 
            this.expandArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.expandArrowPictureBox.BackgroundImage = global::Jango_Desktop.Properties.Resources.expand_arrow_normal;
            this.expandArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.expandArrowPictureBox.Location = new System.Drawing.Point(430, 8);
            this.expandArrowPictureBox.Name = "expandArrowPictureBox";
            this.expandArrowPictureBox.Size = new System.Drawing.Size(16, 17);
            this.expandArrowPictureBox.TabIndex = 0;
            this.expandArrowPictureBox.TabStop = false;
            this.expandArrowPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.expandArrowPictureBox.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.expandArrowPictureBox.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // albumArtPictureBox
            // 
            this.albumArtPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.albumArtPictureBox.Location = new System.Drawing.Point(21, 12);
            this.albumArtPictureBox.Name = "albumArtPictureBox";
            this.albumArtPictureBox.Size = new System.Drawing.Size(132, 110);
            this.albumArtPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumArtPictureBox.TabIndex = 3;
            this.albumArtPictureBox.TabStop = false;
            // 
            // songLbl
            // 
            this.songLbl.AutoSize = true;
            this.songLbl.BackColor = System.Drawing.Color.Transparent;
            this.songLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.songLbl.Location = new System.Drawing.Point(179, 22);
            this.songLbl.Name = "songLbl";
            this.songLbl.Size = new System.Drawing.Size(0, 13);
            this.songLbl.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.BackColor = System.Drawing.Color.Transparent;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.artistLabel.Location = new System.Drawing.Point(179, 45);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(0, 13);
            this.artistLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(333, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rate Song:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(179, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Controls:";
            // 
            // playPauseBtn
            // 
            this.playPauseBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.playPauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseBtn.Image = global::Jango_Desktop.Properties.Resources.control_pause;
            this.playPauseBtn.Location = new System.Drawing.Point(233, 71);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(25, 25);
            this.playPauseBtn.TabIndex = 11;
            this.playPauseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.playPauseBtn.UseVisualStyleBackColor = false;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Image = global::Jango_Desktop.Properties.Resources.control_fastforward;
            this.nextBtn.Location = new System.Drawing.Point(264, 71);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(25, 25);
            this.nextBtn.TabIndex = 12;
            this.nextBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Image = global::Jango_Desktop.Properties.Resources.arrow_refresh;
            this.reloadBtn.Location = new System.Drawing.Point(295, 71);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(25, 25);
            this.reloadBtn.TabIndex = 13;
            this.reloadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // rateUpBtn
            // 
            this.rateUpBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.rateUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rateUpBtn.Image = global::Jango_Desktop.Properties.Resources.emoticon_happy;
            this.rateUpBtn.Location = new System.Drawing.Point(400, 71);
            this.rateUpBtn.Name = "rateUpBtn";
            this.rateUpBtn.Size = new System.Drawing.Size(25, 25);
            this.rateUpBtn.TabIndex = 14;
            this.rateUpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rateUpBtn.UseVisualStyleBackColor = false;
            this.rateUpBtn.Click += new System.EventHandler(this.rateUpBtn_Click);
            // 
            // RateDownBtn
            // 
            this.RateDownBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.RateDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateDownBtn.Image = global::Jango_Desktop.Properties.Resources.emoticon_unhappy;
            this.RateDownBtn.Location = new System.Drawing.Point(431, 71);
            this.RateDownBtn.Name = "RateDownBtn";
            this.RateDownBtn.Size = new System.Drawing.Size(25, 25);
            this.RateDownBtn.TabIndex = 15;
            this.RateDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RateDownBtn.UseVisualStyleBackColor = false;
            this.RateDownBtn.Click += new System.EventHandler(this.RateDownBtn_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.timerLabel.Location = new System.Drawing.Point(416, 105);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 13);
            this.timerLabel.TabIndex = 17;
            // 
            // timeRemainingProgressBar
            // 
            this.timeRemainingProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeRemainingProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(3)))), ((int)(((byte)(2)))));
            this.timeRemainingProgressBar.Location = new System.Drawing.Point(179, 105);
            this.timeRemainingProgressBar.Name = "timeRemainingProgressBar";
            this.timeRemainingProgressBar.Size = new System.Drawing.Size(222, 10);
            this.timeRemainingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timeRemainingProgressBar.TabIndex = 16;
            // 
            // MiniPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Jango_Desktop.Properties.Resources.miniplayerbgtile;
            this.ClientSize = new System.Drawing.Size(463, 133);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timeRemainingProgressBar);
            this.Controls.Add(this.RateDownBtn);
            this.Controls.Add(this.rateUpBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.playPauseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumArtPictureBox);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.songLbl);
            this.Controls.Add(this.expandArrowPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniPlayer";
            this.Text = "Jango Desktop - Mini Player";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MiniPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expandArrowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox expandArrowPictureBox;
        private System.Windows.Forms.PictureBox albumArtPictureBox;
        private System.Windows.Forms.Label songLbl;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playPauseBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button rateUpBtn;
        private System.Windows.Forms.Button RateDownBtn;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ProgressBar timeRemainingProgressBar;

    }
}