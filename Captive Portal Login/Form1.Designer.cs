namespace Captive_Portal_Login
{
    partial class captivePortalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(captivePortalWindow));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.refreshButton = new System.Windows.Forms.Button();
            this.assistanceLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(12, 44);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(708, 556);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::Captive_Portal_Login.Properties.Resources.refresh;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Location = new System.Drawing.Point(12, 8);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 30);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButtonClick);
            // 
            // assistanceLabel
            // 
            this.assistanceLabel.AutoSize = true;
            this.assistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistanceLabel.Location = new System.Drawing.Point(48, 11);
            this.assistanceLabel.Name = "assistanceLabel";
            this.assistanceLabel.Size = new System.Drawing.Size(237, 25);
            this.assistanceLabel.TabIndex = 2;
            this.assistanceLabel.Text = "For assistance, call x4357";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(643, 25);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(41, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "version";
            // 
            // captivePortalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(732, 612);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.assistanceLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "captivePortalWindow";
            this.Text = "Captive Portal Login";
            this.Load += new System.EventHandler(this.captivePortalWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label assistanceLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}

