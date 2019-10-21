﻿namespace HistoryClient
{
    partial class AddMoodPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMoodPage));
            this.enterEventText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.confirmButton = new System.Windows.Forms.Button();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.filepathButton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterEventText
            // 
            this.enterEventText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEventText.Location = new System.Drawing.Point(100, 59);
            this.enterEventText.Multiline = true;
            this.enterEventText.Name = "enterEventText";
            this.enterEventText.Size = new System.Drawing.Size(400, 35);
            this.enterEventText.TabIndex = 0;
            this.enterEventText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterEventText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.confirmButton.Location = new System.Drawing.Point(100, 180);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(175, 50);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Analyze";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.browseFilesButton.Location = new System.Drawing.Point(325, 180);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(175, 50);
            this.browseFilesButton.TabIndex = 2;
            this.browseFilesButton.Text = "Browse";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // filepathButton
            // 
            this.filepathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.filepathButton.Location = new System.Drawing.Point(100, 125);
            this.filepathButton.Multiline = true;
            this.filepathButton.Name = "filepathButton";
            this.filepathButton.ReadOnly = true;
            this.filepathButton.Size = new System.Drawing.Size(400, 35);
            this.filepathButton.TabIndex = 3;
            this.filepathButton.Text = "File\'s location";
            this.filepathButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filepathButton.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(201, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter situation below";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddMoodPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filepathButton);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.enterEventText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMoodPage";
            this.Text = "New record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterEventText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.TextBox filepathButton;
        private System.Windows.Forms.Label label1;
    }
}