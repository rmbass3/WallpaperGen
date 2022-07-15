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
            this.selectButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
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
            this.homePanel.SuspendLayout();
            this.folderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectButton.Location = new System.Drawing.Point(65, 240);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(126, 23);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select Folder";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
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
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(651, 386);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(104, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
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
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(430, 450);
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
            this.creditLabel.Location = new System.Drawing.Point(153, 71);
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
            this.homeTitleLabel.Location = new System.Drawing.Point(19, 28);
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
            this.folderPanel.Controls.Add(this.selectButton);
            this.folderPanel.Controls.Add(this.selectLabel);
            this.folderPanel.Location = new System.Drawing.Point(111, 389);
            this.folderPanel.Name = "folderPanel";
            this.folderPanel.Size = new System.Drawing.Size(47, 42);
            this.folderPanel.TabIndex = 5;
            // 
            // folderNextButton
            // 
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
            this.label2.Location = new System.Drawing.Point(-39, 71);
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
            this.label1.Location = new System.Drawing.Point(-173, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wallpaper Generator";
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.folderPanel);
            this.Name = "AutoForm";
            this.Text = "WallpaperGen";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.folderPanel.ResumeLayout(false);
            this.folderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button selectButton;
        private Label selectLabel;
        private Button createButton;
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
    }
}