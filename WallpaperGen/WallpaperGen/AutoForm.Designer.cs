﻿namespace WallpaperGen
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
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.selectButton);
            this.Name = "AutoForm";
            this.Text = "AutoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button selectButton;
        private Label selectLabel;
        private Button createButton;
        private Button removeButton;
    }
}