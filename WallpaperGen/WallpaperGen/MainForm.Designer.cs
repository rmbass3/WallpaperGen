namespace WallpaperGen
{
    partial class MainForm
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
            this.getWallpapersButton = new System.Windows.Forms.Button();
            this.wallpaperPictureBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.setWallpapers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaperPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // getWallpapersButton
            // 
            this.getWallpapersButton.Location = new System.Drawing.Point(144, 393);
            this.getWallpapersButton.Name = "getWallpapersButton";
            this.getWallpapersButton.Size = new System.Drawing.Size(108, 23);
            this.getWallpapersButton.TabIndex = 0;
            this.getWallpapersButton.Text = "Get Wallpapers";
            this.getWallpapersButton.UseVisualStyleBackColor = true;
            this.getWallpapersButton.Click += new System.EventHandler(this.getWallpapersButton_Click);
            // 
            // wallpaperPictureBox
            // 
            this.wallpaperPictureBox.Location = new System.Drawing.Point(144, 57);
            this.wallpaperPictureBox.Name = "wallpaperPictureBox";
            this.wallpaperPictureBox.Size = new System.Drawing.Size(480, 270);
            this.wallpaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wallpaperPictureBox.TabIndex = 4;
            this.wallpaperPictureBox.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(686, 187);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(36, 187);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(332, 393);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(108, 23);
            this.downloadButton.TabIndex = 7;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // setWallpapers
            // 
            this.setWallpapers.Location = new System.Drawing.Point(516, 393);
            this.setWallpapers.Name = "setWallpapers";
            this.setWallpapers.Size = new System.Drawing.Size(108, 23);
            this.setWallpapers.TabIndex = 8;
            this.setWallpapers.Text = "Set Wallpapers";
            this.setWallpapers.UseVisualStyleBackColor = true;
            this.setWallpapers.Click += new System.EventHandler(this.setWallpapers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setWallpapers);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.wallpaperPictureBox);
            this.Controls.Add(this.getWallpapersButton);
            this.Name = "MainForm";
            this.Text = "WallpaperGen";
            ((System.ComponentModel.ISupportInitialize)(this.wallpaperPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button getWallpapersButton;
        private PictureBox wallpaperPictureBox;
        private Button nextButton;
        private Button backButton;
        private Button downloadButton;
        private Button setWallpapers;
    }
}