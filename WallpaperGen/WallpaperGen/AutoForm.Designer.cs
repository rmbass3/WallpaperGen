namespace WallpaperGen
{
    partial class AutoForm
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
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeNextButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.generateRadio = new System.Windows.Forms.RadioButton();
            this.folderRadio = new System.Windows.Forms.RadioButton();
            this.homeTitleLabel = new System.Windows.Forms.Label();
            this.folderPanel = new System.Windows.Forms.Panel();
            this.folderNextButton = new System.Windows.Forms.Button();
            this.folderBackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.computerStartRadio = new System.Windows.Forms.RadioButton();
            this.dailyRadio = new System.Windows.Forms.RadioButton();
            this.scheduleNextButton = new System.Windows.Forms.Button();
            this.scheduleBackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.dailyPanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dailyLabel = new System.Windows.Forms.Label();
            this.homePanel.SuspendLayout();
            this.folderPanel.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            this.dailyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectFolderButton.Location = new System.Drawing.Point(65, 240);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(126, 23);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectLabel.Location = new System.Drawing.Point(221, 244);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(140, 14);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "No folder selected.";
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(12, 415);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(174, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove existing setup";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.homeNextButton);
            this.homePanel.Controls.Add(this.creditLabel);
            this.homePanel.Controls.Add(this.generateRadio);
            this.homePanel.Controls.Add(this.removeButton);
            this.homePanel.Controls.Add(this.folderRadio);
            this.homePanel.Controls.Add(this.homeTitleLabel);
            this.homePanel.Location = new System.Drawing.Point(35, 389);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(49, 42);
            this.homePanel.TabIndex = 4;
            // 
            // homeNextButton
            // 
            this.homeNextButton.Enabled = false;
            this.homeNextButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeNextButton.Location = new System.Drawing.Point(343, 415);
            this.homeNextButton.Name = "homeNextButton";
            this.homeNextButton.Size = new System.Drawing.Size(75, 23);
            this.homeNextButton.TabIndex = 4;
            this.homeNextButton.Text = "Next";
            this.homeNextButton.UseVisualStyleBackColor = true;
            this.homeNextButton.Click += new System.EventHandler(this.homeNextButton_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditLabel.Location = new System.Drawing.Point(-38, 71);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(104, 17);
            this.creditLabel.TabIndex = 3;
            this.creditLabel.Text = "2022 rmbass3";
            // 
            // generateRadio
            // 
            this.generateRadio.AutoSize = true;
            this.generateRadio.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateRadio.Location = new System.Drawing.Point(236, 239);
            this.generateRadio.Name = "generateRadio";
            this.generateRadio.Size = new System.Drawing.Size(158, 18);
            this.generateRadio.TabIndex = 2;
            this.generateRadio.TabStop = true;
            this.generateRadio.Text = "Generate wallpapers";
            this.generateRadio.UseVisualStyleBackColor = true;
            this.generateRadio.CheckedChanged += new System.EventHandler(this.generateRadio_CheckedChanged);
            // 
            // folderRadio
            // 
            this.folderRadio.AutoSize = true;
            this.folderRadio.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderRadio.Location = new System.Drawing.Point(35, 240);
            this.folderRadio.Name = "folderRadio";
            this.folderRadio.Size = new System.Drawing.Size(151, 18);
            this.folderRadio.TabIndex = 1;
            this.folderRadio.TabStop = true;
            this.folderRadio.Text = "Select from folder";
            this.folderRadio.UseVisualStyleBackColor = true;
            this.folderRadio.CheckedChanged += new System.EventHandler(this.folderRadio_CheckedChanged);
            // 
            // homeTitleLabel
            // 
            this.homeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeTitleLabel.AutoSize = true;
            this.homeTitleLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeTitleLabel.Location = new System.Drawing.Point(-172, 28);
            this.homeTitleLabel.Name = "homeTitleLabel";
            this.homeTitleLabel.Size = new System.Drawing.Size(399, 43);
            this.homeTitleLabel.TabIndex = 0;
            this.homeTitleLabel.Text = "Wallpaper Generator";
            // 
            // folderPanel
            // 
            this.folderPanel.Controls.Add(this.folderNextButton);
            this.folderPanel.Controls.Add(this.folderBackButton);
            this.folderPanel.Controls.Add(this.label2);
            this.folderPanel.Controls.Add(this.label1);
            this.folderPanel.Controls.Add(this.selectFolderButton);
            this.folderPanel.Controls.Add(this.selectLabel);
            this.folderPanel.Location = new System.Drawing.Point(90, 380);
            this.folderPanel.Name = "folderPanel";
            this.folderPanel.Size = new System.Drawing.Size(62, 58);
            this.folderPanel.TabIndex = 5;
            // 
            // folderNextButton
            // 
            this.folderNextButton.Enabled = false;
            this.folderNextButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderNextButton.Location = new System.Drawing.Point(314, 415);
            this.folderNextButton.Name = "folderNextButton";
            this.folderNextButton.Size = new System.Drawing.Size(104, 23);
            this.folderNextButton.TabIndex = 7;
            this.folderNextButton.Text = "Next";
            this.folderNextButton.UseVisualStyleBackColor = true;
            this.folderNextButton.Click += new System.EventHandler(this.folderNextButton_Click);
            // 
            // folderBackButton
            // 
            this.folderBackButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderBackButton.Location = new System.Drawing.Point(12, 415);
            this.folderBackButton.Name = "folderBackButton";
            this.folderBackButton.Size = new System.Drawing.Size(104, 23);
            this.folderBackButton.TabIndex = 6;
            this.folderBackButton.Text = "Back";
            this.folderBackButton.UseVisualStyleBackColor = true;
            this.folderBackButton.Click += new System.EventHandler(this.folderBackButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "2022 rmbass3";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-165, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wallpaper Generator";
            // 
            // schedulePanel
            // 
            this.schedulePanel.Controls.Add(this.computerStartRadio);
            this.schedulePanel.Controls.Add(this.dailyRadio);
            this.schedulePanel.Controls.Add(this.scheduleNextButton);
            this.schedulePanel.Controls.Add(this.scheduleBackButton);
            this.schedulePanel.Controls.Add(this.label3);
            this.schedulePanel.Controls.Add(this.label4);
            this.schedulePanel.Controls.Add(this.changeLabel);
            this.schedulePanel.Location = new System.Drawing.Point(167, 380);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(54, 58);
            this.schedulePanel.TabIndex = 6;
            // 
            // computerStartRadio
            // 
            this.computerStartRadio.AutoSize = true;
            this.computerStartRadio.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.computerStartRadio.Location = new System.Drawing.Point(69, 205);
            this.computerStartRadio.Name = "computerStartRadio";
            this.computerStartRadio.Size = new System.Drawing.Size(193, 18);
            this.computerStartRadio.TabIndex = 9;
            this.computerStartRadio.TabStop = true;
            this.computerStartRadio.Text = "When the computer starts";
            this.computerStartRadio.UseVisualStyleBackColor = true;
            this.computerStartRadio.CheckedChanged += new System.EventHandler(this.computerStartRadio_CheckedChanged);
            // 
            // dailyRadio
            // 
            this.dailyRadio.AutoSize = true;
            this.dailyRadio.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyRadio.Location = new System.Drawing.Point(70, 181);
            this.dailyRadio.Name = "dailyRadio";
            this.dailyRadio.Size = new System.Drawing.Size(60, 18);
            this.dailyRadio.TabIndex = 8;
            this.dailyRadio.TabStop = true;
            this.dailyRadio.Text = "Daily";
            this.dailyRadio.UseVisualStyleBackColor = true;
            this.dailyRadio.CheckedChanged += new System.EventHandler(this.dailyRadio_CheckedChanged);
            // 
            // scheduleNextButton
            // 
            this.scheduleNextButton.Enabled = false;
            this.scheduleNextButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scheduleNextButton.Location = new System.Drawing.Point(314, 415);
            this.scheduleNextButton.Name = "scheduleNextButton";
            this.scheduleNextButton.Size = new System.Drawing.Size(104, 23);
            this.scheduleNextButton.TabIndex = 7;
            this.scheduleNextButton.Text = "Next";
            this.scheduleNextButton.UseVisualStyleBackColor = true;
            this.scheduleNextButton.Click += new System.EventHandler(this.scheduleNextButton_Click);
            // 
            // scheduleBackButton
            // 
            this.scheduleBackButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scheduleBackButton.Location = new System.Drawing.Point(12, 415);
            this.scheduleBackButton.Name = "scheduleBackButton";
            this.scheduleBackButton.Size = new System.Drawing.Size(104, 23);
            this.scheduleBackButton.TabIndex = 6;
            this.scheduleBackButton.Text = "Back";
            this.scheduleBackButton.UseVisualStyleBackColor = true;
            this.scheduleBackButton.Click += new System.EventHandler(this.scheduleBackButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-30, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "2022 rmbass3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-169, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wallpaper Generator";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeLabel.Location = new System.Drawing.Point(70, 136);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(294, 14);
            this.changeLabel.TabIndex = 1;
            this.changeLabel.Text = "When do you want the wallpaper to change?";
            // 
            // dailyPanel
            // 
            this.dailyPanel.Controls.Add(this.radioButton1);
            this.dailyPanel.Controls.Add(this.radioButton2);
            this.dailyPanel.Controls.Add(this.button1);
            this.dailyPanel.Controls.Add(this.button2);
            this.dailyPanel.Controls.Add(this.label5);
            this.dailyPanel.Controls.Add(this.label6);
            this.dailyPanel.Controls.Add(this.dailyLabel);
            this.dailyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailyPanel.Location = new System.Drawing.Point(0, 0);
            this.dailyPanel.Name = "dailyPanel";
            this.dailyPanel.Size = new System.Drawing.Size(430, 450);
            this.dailyPanel.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(69, 205);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(193, 18);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "When the computer starts";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(70, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 18);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Daily";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(314, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(167, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "2022 rmbass3";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 43);
            this.label6.TabIndex = 4;
            this.label6.Text = "Wallpaper Generator";
            // 
            // dailyLabel
            // 
            this.dailyLabel.AutoSize = true;
            this.dailyLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyLabel.Location = new System.Drawing.Point(70, 136);
            this.dailyLabel.Name = "dailyLabel";
            this.dailyLabel.Size = new System.Drawing.Size(294, 14);
            this.dailyLabel.TabIndex = 1;
            this.dailyLabel.Text = "When do you want the wallpaper to change?";
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.dailyPanel);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.folderPanel);
            this.Controls.Add(this.homePanel);
            this.Name = "AutoForm";
            this.Text = "WallpaperGen";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.folderPanel.ResumeLayout(false);
            this.folderPanel.PerformLayout();
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            this.dailyPanel.ResumeLayout(false);
            this.dailyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button selectFolderButton;
        private Label selectLabel;
        private Button removeButton;
        private Panel homePanel;
        private Label homeTitleLabel;
        private Button homeNextButton;
        private Label creditLabel;
        private RadioButton generateRadio;
        private RadioButton folderRadio;
        private Panel folderPanel;
        private Label label1;
        private Label label2;
        private Button folderBackButton;
        private Button folderNextButton;
        private Panel schedulePanel;
        private Button scheduleNextButton;
        private Button scheduleBackButton;
        private Label label3;
        private Label label4;
        private Label changeLabel;
        private RadioButton dailyRadio;
        private RadioButton computerStartRadio;
        private Panel dailyPanel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label dailyLabel;
    }
}