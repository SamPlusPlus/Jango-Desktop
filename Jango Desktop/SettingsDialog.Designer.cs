namespace Jango_Desktop
{
    partial class SettingsDialog
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
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.displaySongRating = new System.Windows.Forms.CheckBox();
            this.autologingroupbox = new System.Windows.Forms.GroupBox();
            this.SecurityRisksLink = new System.Windows.Forms.LinkLabel();
            this.jangoPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.jangoUsernameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoLoginCheckbox = new System.Windows.Forms.CheckBox();
            this.displaySongTipsAtEndOfSongCheckBox = new System.Windows.Forms.CheckBox();
            this.displaySongTips = new System.Windows.Forms.CheckBox();
            this.KeyboardTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RateUpSet = new System.Windows.Forms.LinkLabel();
            this.NextTrackSet = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayPauseLabel = new System.Windows.Forms.Label();
            this.NextTrackLabel = new System.Windows.Forms.Label();
            this.RateupLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PlayPauseSet = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RateDownLabel = new System.Windows.Forms.Label();
            this.DisplaySongLabel = new System.Windows.Forms.Label();
            this.RateDownSet = new System.Windows.Forms.LinkLabel();
            this.DisplaySongSet = new System.Windows.Forms.LinkLabel();
            this.settingsSaveBtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.startMinimized = new System.Windows.Forms.CheckBox();
            this.SettingsTabControl.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            this.autologingroupbox.SuspendLayout();
            this.KeyboardTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsTabControl.Controls.Add(this.PlayerTab);
            this.SettingsTabControl.Controls.Add(this.KeyboardTab);
            this.SettingsTabControl.Location = new System.Drawing.Point(12, 12);
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(485, 255);
            this.SettingsTabControl.TabIndex = 0;
            // 
            // PlayerTab
            // 
            this.PlayerTab.Controls.Add(this.startMinimized);
            this.PlayerTab.Controls.Add(this.displaySongRating);
            this.PlayerTab.Controls.Add(this.autologingroupbox);
            this.PlayerTab.Controls.Add(this.displaySongTipsAtEndOfSongCheckBox);
            this.PlayerTab.Controls.Add(this.displaySongTips);
            this.PlayerTab.Location = new System.Drawing.Point(4, 22);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerTab.Size = new System.Drawing.Size(477, 229);
            this.PlayerTab.TabIndex = 0;
            this.PlayerTab.Text = "Player";
            this.PlayerTab.UseVisualStyleBackColor = true;
            // 
            // displaySongRating
            // 
            this.displaySongRating.AutoSize = true;
            this.displaySongRating.Location = new System.Drawing.Point(7, 61);
            this.displaySongRating.Name = "displaySongRating";
            this.displaySongRating.Size = new System.Drawing.Size(165, 17);
            this.displaySongRating.TabIndex = 4;
            this.displaySongRating.Text = "Display song rating ballon tips";
            this.displaySongRating.UseVisualStyleBackColor = true;
            // 
            // autologingroupbox
            // 
            this.autologingroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autologingroupbox.Controls.Add(this.SecurityRisksLink);
            this.autologingroupbox.Controls.Add(this.jangoPasswordTxtBox);
            this.autologingroupbox.Controls.Add(this.jangoUsernameTxtBox);
            this.autologingroupbox.Controls.Add(this.label2);
            this.autologingroupbox.Controls.Add(this.label1);
            this.autologingroupbox.Controls.Add(this.AutoLoginCheckbox);
            this.autologingroupbox.Location = new System.Drawing.Point(6, 116);
            this.autologingroupbox.Name = "autologingroupbox";
            this.autologingroupbox.Size = new System.Drawing.Size(213, 107);
            this.autologingroupbox.TabIndex = 3;
            this.autologingroupbox.TabStop = false;
            this.autologingroupbox.Text = "Auto Login";
            // 
            // SecurityRisksLink
            // 
            this.SecurityRisksLink.AutoSize = true;
            this.SecurityRisksLink.Location = new System.Drawing.Point(8, 82);
            this.SecurityRisksLink.Name = "SecurityRisksLink";
            this.SecurityRisksLink.Size = new System.Drawing.Size(80, 13);
            this.SecurityRisksLink.TabIndex = 7;
            this.SecurityRisksLink.TabStop = true;
            this.SecurityRisksLink.Text = "Security Risks?";
            this.SecurityRisksLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SecurityRisksLink_LinkClicked);
            // 
            // jangoPasswordTxtBox
            // 
            this.jangoPasswordTxtBox.Location = new System.Drawing.Point(66, 45);
            this.jangoPasswordTxtBox.Name = "jangoPasswordTxtBox";
            this.jangoPasswordTxtBox.Size = new System.Drawing.Size(141, 20);
            this.jangoPasswordTxtBox.TabIndex = 6;
            this.jangoPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // jangoUsernameTxtBox
            // 
            this.jangoUsernameTxtBox.Location = new System.Drawing.Point(66, 19);
            this.jangoUsernameTxtBox.Name = "jangoUsernameTxtBox";
            this.jangoUsernameTxtBox.Size = new System.Drawing.Size(141, 20);
            this.jangoUsernameTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // AutoLoginCheckbox
            // 
            this.AutoLoginCheckbox.AutoSize = true;
            this.AutoLoginCheckbox.Location = new System.Drawing.Point(133, 82);
            this.AutoLoginCheckbox.Name = "AutoLoginCheckbox";
            this.AutoLoginCheckbox.Size = new System.Drawing.Size(80, 17);
            this.AutoLoginCheckbox.TabIndex = 2;
            this.AutoLoginCheckbox.Text = "Auto Login ";
            this.AutoLoginCheckbox.UseVisualStyleBackColor = true;
            // 
            // displaySongTipsAtEndOfSongCheckBox
            // 
            this.displaySongTipsAtEndOfSongCheckBox.AutoSize = true;
            this.displaySongTipsAtEndOfSongCheckBox.Location = new System.Drawing.Point(7, 38);
            this.displaySongTipsAtEndOfSongCheckBox.Name = "displaySongTipsAtEndOfSongCheckBox";
            this.displaySongTipsAtEndOfSongCheckBox.Size = new System.Drawing.Size(213, 17);
            this.displaySongTipsAtEndOfSongCheckBox.TabIndex = 1;
            this.displaySongTipsAtEndOfSongCheckBox.Text = "Display song balloon tips at end of song";
            this.displaySongTipsAtEndOfSongCheckBox.UseVisualStyleBackColor = true;
            // 
            // displaySongTips
            // 
            this.displaySongTips.AutoSize = true;
            this.displaySongTips.Location = new System.Drawing.Point(7, 15);
            this.displaySongTips.Name = "displaySongTips";
            this.displaySongTips.Size = new System.Drawing.Size(241, 17);
            this.displaySongTips.TabIndex = 0;
            this.displaySongTips.Text = "Display song balloon tips at beginning of song";
            this.displaySongTips.UseVisualStyleBackColor = true;
            // 
            // KeyboardTab
            // 
            this.KeyboardTab.Controls.Add(this.tableLayoutPanel1);
            this.KeyboardTab.Location = new System.Drawing.Point(4, 22);
            this.KeyboardTab.Name = "KeyboardTab";
            this.KeyboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.KeyboardTab.Size = new System.Drawing.Size(477, 210);
            this.KeyboardTab.TabIndex = 1;
            this.KeyboardTab.Text = "Keyboard Shortcuts";
            this.KeyboardTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.03756F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.67136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.52582F));
            this.tableLayoutPanel1.Controls.Add(this.RateUpSet, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NextTrackSet, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlayPauseLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NextTrackLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RateupLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PlayPauseSet, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RateDownLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DisplaySongLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RateDownSet, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.DisplaySongSet, 2, 5);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 134);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // RateUpSet
            // 
            this.RateUpSet.AutoSize = true;
            this.RateUpSet.Location = new System.Drawing.Point(340, 68);
            this.RateUpSet.Name = "RateUpSet";
            this.RateUpSet.Size = new System.Drawing.Size(23, 13);
            this.RateUpSet.TabIndex = 17;
            this.RateUpSet.TabStop = true;
            this.RateUpSet.Text = "Set";
            this.RateUpSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RateUpSet_LinkClicked);
            // 
            // NextTrackSet
            // 
            this.NextTrackSet.AutoSize = true;
            this.NextTrackSet.Location = new System.Drawing.Point(340, 46);
            this.NextTrackSet.Name = "NextTrackSet";
            this.NextTrackSet.Size = new System.Drawing.Size(23, 13);
            this.NextTrackSet.TabIndex = 16;
            this.NextTrackSet.TabStop = true;
            this.NextTrackSet.Text = "Set";
            this.NextTrackSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextTrackSet_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Play/Pause ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Set";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shortcut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Function";
            // 
            // PlayPauseLabel
            // 
            this.PlayPauseLabel.AutoSize = true;
            this.PlayPauseLabel.Location = new System.Drawing.Point(160, 24);
            this.PlayPauseLabel.Name = "PlayPauseLabel";
            this.PlayPauseLabel.Size = new System.Drawing.Size(65, 13);
            this.PlayPauseLabel.TabIndex = 0;
            this.PlayPauseLabel.Text = "Play/Pause ";
            // 
            // NextTrackLabel
            // 
            this.NextTrackLabel.AutoSize = true;
            this.NextTrackLabel.Location = new System.Drawing.Point(160, 46);
            this.NextTrackLabel.Name = "NextTrackLabel";
            this.NextTrackLabel.Size = new System.Drawing.Size(60, 13);
            this.NextTrackLabel.TabIndex = 1;
            this.NextTrackLabel.Text = "Next Track";
            // 
            // RateupLabel
            // 
            this.RateupLabel.AutoSize = true;
            this.RateupLabel.Location = new System.Drawing.Point(160, 68);
            this.RateupLabel.Name = "RateupLabel";
            this.RateupLabel.Size = new System.Drawing.Size(50, 13);
            this.RateupLabel.TabIndex = 2;
            this.RateupLabel.Text = "Rate Up ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Next Track";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Rate Up ";
            // 
            // PlayPauseSet
            // 
            this.PlayPauseSet.AutoSize = true;
            this.PlayPauseSet.Location = new System.Drawing.Point(340, 24);
            this.PlayPauseSet.Name = "PlayPauseSet";
            this.PlayPauseSet.Size = new System.Drawing.Size(23, 13);
            this.PlayPauseSet.TabIndex = 15;
            this.PlayPauseSet.TabStop = true;
            this.PlayPauseSet.Text = "Set";
            this.PlayPauseSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PlayPauseSet_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Rate Down ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Display Song";
            // 
            // RateDownLabel
            // 
            this.RateDownLabel.AutoSize = true;
            this.RateDownLabel.Location = new System.Drawing.Point(160, 90);
            this.RateDownLabel.Name = "RateDownLabel";
            this.RateDownLabel.Size = new System.Drawing.Size(64, 13);
            this.RateDownLabel.TabIndex = 4;
            this.RateDownLabel.Text = "Rate Down ";
            // 
            // DisplaySongLabel
            // 
            this.DisplaySongLabel.AutoSize = true;
            this.DisplaySongLabel.Location = new System.Drawing.Point(160, 112);
            this.DisplaySongLabel.Name = "DisplaySongLabel";
            this.DisplaySongLabel.Size = new System.Drawing.Size(69, 13);
            this.DisplaySongLabel.TabIndex = 5;
            this.DisplaySongLabel.Text = "Display Song";
            // 
            // RateDownSet
            // 
            this.RateDownSet.AutoSize = true;
            this.RateDownSet.Location = new System.Drawing.Point(340, 90);
            this.RateDownSet.Name = "RateDownSet";
            this.RateDownSet.Size = new System.Drawing.Size(23, 13);
            this.RateDownSet.TabIndex = 19;
            this.RateDownSet.TabStop = true;
            this.RateDownSet.Text = "Set";
            this.RateDownSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RateDownSet_LinkClicked);
            // 
            // DisplaySongSet
            // 
            this.DisplaySongSet.AutoSize = true;
            this.DisplaySongSet.Location = new System.Drawing.Point(340, 112);
            this.DisplaySongSet.Name = "DisplaySongSet";
            this.DisplaySongSet.Size = new System.Drawing.Size(23, 13);
            this.DisplaySongSet.TabIndex = 20;
            this.DisplaySongSet.TabStop = true;
            this.DisplaySongSet.Text = "Set";
            this.DisplaySongSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DisplaySongSet_LinkClicked);
            // 
            // settingsSaveBtn
            // 
            this.settingsSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsSaveBtn.Location = new System.Drawing.Point(337, 273);
            this.settingsSaveBtn.Name = "settingsSaveBtn";
            this.settingsSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.settingsSaveBtn.TabIndex = 1;
            this.settingsSaveBtn.Text = "Save";
            this.settingsSaveBtn.UseVisualStyleBackColor = true;
            this.settingsSaveBtn.Click += new System.EventHandler(this.settingsSaveBtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.Location = new System.Drawing.Point(418, 273);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // startMinimized
            // 
            this.startMinimized.AutoSize = true;
            this.startMinimized.Location = new System.Drawing.Point(7, 84);
            this.startMinimized.Name = "startMinimized";
            this.startMinimized.Size = new System.Drawing.Size(96, 17);
            this.startMinimized.TabIndex = 5;
            this.startMinimized.Text = "Start minimized";
            this.startMinimized.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 303);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.settingsSaveBtn);
            this.Controls.Add(this.SettingsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.SettingsTabControl.ResumeLayout(false);
            this.PlayerTab.ResumeLayout(false);
            this.PlayerTab.PerformLayout();
            this.autologingroupbox.ResumeLayout(false);
            this.autologingroupbox.PerformLayout();
            this.KeyboardTab.ResumeLayout(false);
            this.KeyboardTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage PlayerTab;
        private System.Windows.Forms.CheckBox displaySongTips;
        private System.Windows.Forms.Button settingsSaveBtn;
        private System.Windows.Forms.CheckBox displaySongTipsAtEndOfSongCheckBox;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.GroupBox autologingroupbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AutoLoginCheckbox;
        private System.Windows.Forms.LinkLabel SecurityRisksLink;
        private System.Windows.Forms.TextBox jangoPasswordTxtBox;
        private System.Windows.Forms.TextBox jangoUsernameTxtBox;
        private System.Windows.Forms.TabPage KeyboardTab;
        private System.Windows.Forms.Label PlayPauseLabel;
        private System.Windows.Forms.Label RateupLabel;
        private System.Windows.Forms.Label NextTrackLabel;
        private System.Windows.Forms.Label DisplaySongLabel;
        private System.Windows.Forms.Label RateDownLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel PlayPauseSet;
        private System.Windows.Forms.LinkLabel DisplaySongSet;
        private System.Windows.Forms.LinkLabel RateDownSet;
        private System.Windows.Forms.LinkLabel RateUpSet;
        private System.Windows.Forms.LinkLabel NextTrackSet;
        private System.Windows.Forms.CheckBox displaySongRating;
        private System.Windows.Forms.CheckBox startMinimized;
    }
}