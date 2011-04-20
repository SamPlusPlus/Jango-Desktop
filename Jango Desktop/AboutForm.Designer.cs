namespace Jango_Desktop
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.okButton = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.LinkLabel();
            this.donateImage = new System.Windows.Forms.PictureBox();
            this.openSourceLabel = new System.Windows.Forms.Label();
            this.contributeImage = new System.Windows.Forms.PictureBox();
            this.contributeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.donateLabel = new System.Windows.Forms.Label();
            this.donateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FamFamIcons = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.donateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contributeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(379, 247);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(12, 9);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(75, 13);
            this.labelProductName.TabIndex = 25;
            this.labelProductName.Text = "Product Name";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 26;
            this.labelVersion.Text = "Version";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(12, 79);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(51, 13);
            this.labelCopyright.TabIndex = 27;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 56);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(55, 13);
            this.labelCompanyName.TabIndex = 29;
            this.labelCompanyName.TabStop = true;
            this.labelCompanyName.Text = "linkLabel1";
            this.labelCompanyName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCompanyName_LinkClicked);
            // 
            // donateImage
            // 
            this.donateImage.Image = global::Jango_Desktop.Properties.Resources.money;
            this.donateImage.Location = new System.Drawing.Point(15, 185);
            this.donateImage.Name = "donateImage";
            this.donateImage.Size = new System.Drawing.Size(18, 17);
            this.donateImage.TabIndex = 30;
            this.donateImage.TabStop = false;
            // 
            // openSourceLabel
            // 
            this.openSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.openSourceLabel.AutoSize = true;
            this.openSourceLabel.Location = new System.Drawing.Point(11, 160);
            this.openSourceLabel.Name = "openSourceLabel";
            this.openSourceLabel.Size = new System.Drawing.Size(392, 13);
            this.openSourceLabel.TabIndex = 31;
            this.openSourceLabel.Text = "Jango Desktop is now open source! We invite you to come make it better with us.";
            // 
            // contributeImage
            // 
            this.contributeImage.Image = global::Jango_Desktop.Properties.Resources.application_xp_terminal;
            this.contributeImage.Location = new System.Drawing.Point(15, 140);
            this.contributeImage.Name = "contributeImage";
            this.contributeImage.Size = new System.Drawing.Size(18, 17);
            this.contributeImage.TabIndex = 33;
            this.contributeImage.TabStop = false;
            // 
            // contributeLinkLabel
            // 
            this.contributeLinkLabel.AutoSize = true;
            this.contributeLinkLabel.Location = new System.Drawing.Point(39, 144);
            this.contributeLinkLabel.Name = "contributeLinkLabel";
            this.contributeLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.contributeLinkLabel.TabIndex = 34;
            this.contributeLinkLabel.TabStop = true;
            this.contributeLinkLabel.Text = "Contribute";
            this.contributeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contributeLabel_LinkClicked);
            // 
            // donateLabel
            // 
            this.donateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.donateLabel.AutoSize = true;
            this.donateLabel.Location = new System.Drawing.Point(11, 205);
            this.donateLabel.Name = "donateLabel";
            this.donateLabel.Size = new System.Drawing.Size(386, 13);
            this.donateLabel.TabIndex = 35;
            this.donateLabel.Text = "If you find this application useful please consider supporting further developmen" +
                "t.";
            // 
            // donateLinkLabel
            // 
            this.donateLinkLabel.AutoSize = true;
            this.donateLinkLabel.Location = new System.Drawing.Point(38, 187);
            this.donateLinkLabel.Name = "donateLinkLabel";
            this.donateLinkLabel.Size = new System.Drawing.Size(42, 13);
            this.donateLinkLabel.TabIndex = 36;
            this.donateLinkLabel.TabStop = true;
            this.donateLinkLabel.Text = "Donate";
            this.donateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.donateLinkLabel_LinkClicked);
            // 
            // FamFamIcons
            // 
            this.FamFamIcons.AutoSize = true;
            this.FamFamIcons.Location = new System.Drawing.Point(12, 107);
            this.FamFamIcons.Name = "FamFamIcons";
            this.FamFamIcons.Size = new System.Drawing.Size(191, 13);
            this.FamFamIcons.TabIndex = 37;
            this.FamFamIcons.TabStop = true;
            this.FamFamIcons.Text = "Icons from http://www.famfamfam.com";
            this.FamFamIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FamFamIcons_LinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 282);
            this.Controls.Add(this.FamFamIcons);
            this.Controls.Add(this.donateLinkLabel);
            this.Controls.Add(this.donateLabel);
            this.Controls.Add(this.contributeLinkLabel);
            this.Controls.Add(this.donateImage);
            this.Controls.Add(this.contributeImage);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.openSourceLabel);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Jango Desktop";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donateImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contributeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.LinkLabel labelCompanyName;
        private System.Windows.Forms.PictureBox donateImage;
        private System.Windows.Forms.Label openSourceLabel;
        private System.Windows.Forms.PictureBox contributeImage;
        private System.Windows.Forms.LinkLabel contributeLinkLabel;
        private System.Windows.Forms.Label donateLabel;
        private System.Windows.Forms.LinkLabel donateLinkLabel;
        private System.Windows.Forms.LinkLabel FamFamIcons;

    }
}
