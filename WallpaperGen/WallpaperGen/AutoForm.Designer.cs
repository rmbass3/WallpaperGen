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
            this.homeTitleLabel = new System.Windows.Forms.Label();
            this.folderRadio = new System.Windows.Forms.RadioButton();
            this.generateRadio = new System.Windows.Forms.RadioButton();
            this.creditLabel = new System.Windows.Forms.Label();
            this.homeNextButton = new System.Windows.Forms.Button();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(41, 37);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(104, 23);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select Folder";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(151, 41);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(106, 15);
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
            this.removeButton.Location = new System.Drawing.Point(41, 386);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(104, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.homeNextButton);
            this.homePanel.Controls.Add(this.creditLabel);
            this.homePanel.Controls.Add(this.generateRadio);
            this.homePanel.Controls.Add(this.folderRadio);
            this.homePanel.Controls.Add(this.homeTitleLabel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(430, 450);
            this.homePanel.TabIndex = 4;
            // 
            // homeTitleLabel
            // 
            this.homeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeTitleLabel.AutoSize = true;
            this.homeTitleLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeTitleLabel.Location = new System.Drawing.Point(19, 63);
            this.homeTitleLabel.Name = "homeTitleLabel";
            this.homeTitleLabel.Size = new System.Drawing.Size(399, 43);
            this.homeTitleLabel.TabIndex = 0;
            this.homeTitleLabel.Text = "Wallpaper Generator";
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
            // 
            // creditLabel
            // 
            this.creditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditLabel.Location = new System.Drawing.Point(153, 106);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(104, 17);
            this.creditLabel.TabIndex = 3;
            this.creditLabel.Text = "2022 rmbass3";
            // 
            // homeNextButton
            // 
            this.homeNextButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeNextButton.Location = new System.Drawing.Point(343, 415);
            this.homeNextButton.Name = "homeNextButton";
            this.homeNextButton.Size = new System.Drawing.Size(75, 23);
            this.homeNextButton.TabIndex = 4;
            this.homeNextButton.Text = "Next";
            this.homeNextButton.UseVisualStyleBackColor = true;
            this.homeNextButton.Click += new System.EventHandler(this.homeNextButton_Click);
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.selectButton);
            this.Name = "AutoForm";
            this.Text = "AutoForm";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}