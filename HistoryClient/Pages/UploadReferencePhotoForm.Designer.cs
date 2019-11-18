namespace HistoryClient
{
    partial class UploadReferencePhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadReferencePhoto));
            this.filepathButton = new System.Windows.Forms.TextBox();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filepathButton
            // 
            this.filepathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.filepathButton.Location = new System.Drawing.Point(173, 202);
            this.filepathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filepathButton.Multiline = true;
            this.filepathButton.Name = "filepathButton";
            this.filepathButton.ReadOnly = true;
            this.filepathButton.Size = new System.Drawing.Size(268, 35);
            this.filepathButton.TabIndex = 4;
            this.filepathButton.Text = "Select File";
            this.filepathButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filepathButton.TextChanged += new System.EventHandler(this.filepathButton_TextChanged);
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.browseFilesButton.Location = new System.Drawing.Point(447, 202);
            this.browseFilesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(127, 36);
            this.browseFilesButton.TabIndex = 5;
            this.browseFilesButton.Text = "Browse";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.confirmButton.Location = new System.Drawing.Point(297, 277);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(175, 50);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm!";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(168, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hello! Upload a photo with ONLY your face";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UploadReferencePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.filepathButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadReferencePhoto";
            this.Text = "We want to recognize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filepathButton;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
    }
}