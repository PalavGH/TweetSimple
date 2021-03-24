
namespace DashboardCTwitter
{
    partial class TwitterDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterDashboard));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.imagePreview = new System.Windows.Forms.PictureBox();
            this.tweetText = new System.Windows.Forms.RichTextBox();
            this.charCount = new System.Windows.Forms.Label();
            this.tweetButton = new System.Windows.Forms.Button();
            this.imageSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(193, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginLogo
            // 
            this.loginLogo.BackColor = System.Drawing.Color.Transparent;
            this.loginLogo.Image = ((System.Drawing.Image)(resources.GetObject("loginLogo.Image")));
            this.loginLogo.Location = new System.Drawing.Point(84, 185);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(250, 267);
            this.loginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginLogo.TabIndex = 1;
            this.loginLogo.TabStop = false;
            this.loginLogo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imagePreview
            // 
            this.imagePreview.BackColor = System.Drawing.Color.Transparent;
            this.imagePreview.Location = new System.Drawing.Point(45, 403);
            this.imagePreview.Name = "imagePreview";
            this.imagePreview.Size = new System.Drawing.Size(312, 212);
            this.imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePreview.TabIndex = 2;
            this.imagePreview.TabStop = false;
            // 
            // tweetText
            // 
            this.tweetText.Location = new System.Drawing.Point(45, 178);
            this.tweetText.Name = "tweetText";
            this.tweetText.Size = new System.Drawing.Size(313, 208);
            this.tweetText.TabIndex = 3;
            this.tweetText.Text = "";
            this.tweetText.Visible = false;
            this.tweetText.TextChanged += new System.EventHandler(this.tweetText_TextChanged);
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.BackColor = System.Drawing.Color.Transparent;
            this.charCount.ForeColor = System.Drawing.Color.Black;
            this.charCount.Location = new System.Drawing.Point(45, 160);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(36, 15);
            this.charCount.TabIndex = 4;
            this.charCount.Text = "0/280";
            this.charCount.Visible = false;
            this.charCount.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tweetButton
            // 
            this.tweetButton.Location = new System.Drawing.Point(282, 156);
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Size = new System.Drawing.Size(75, 23);
            this.tweetButton.TabIndex = 5;
            this.tweetButton.Text = "Tweet";
            this.tweetButton.UseVisualStyleBackColor = true;
            this.tweetButton.Visible = false;
            this.tweetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageSelect
            // 
            this.imageSelect.Location = new System.Drawing.Point(282, 383);
            this.imageSelect.Name = "imageSelect";
            this.imageSelect.Size = new System.Drawing.Size(75, 23);
            this.imageSelect.TabIndex = 6;
            this.imageSelect.Text = "Select Image";
            this.imageSelect.UseVisualStyleBackColor = true;
            this.imageSelect.Visible = false;
            this.imageSelect.Click += new System.EventHandler(this.imageSelect_Click);
            // 
            // TwitterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::DashboardCTwitter.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 627);
            this.Controls.Add(this.imageSelect);
            this.Controls.Add(this.tweetButton);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.tweetText);
            this.Controls.Add(this.imagePreview);
            this.Controls.Add(this.loginLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TwitterDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleTweet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.PictureBox imagePreview;
        private System.Windows.Forms.RichTextBox tweetText;
        private System.Windows.Forms.Label charCount;
        private System.Windows.Forms.Button tweetButton;
        private System.Windows.Forms.Button imageSelect;
    }
}

