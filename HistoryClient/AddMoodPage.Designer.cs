namespace HistoryClient
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
            this.enterEventText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.confirmButton = new System.Windows.Forms.Button();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.filepathButton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterEventText
            // 
            this.enterEventText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEventText.Location = new System.Drawing.Point(228, 116);
            this.enterEventText.Multiline = true;
            this.enterEventText.Name = "enterEventText";
            this.enterEventText.Size = new System.Drawing.Size(364, 46);
            this.enterEventText.TabIndex = 0;
            this.enterEventText.Text = "Enter the event";
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
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.confirmButton.Location = new System.Drawing.Point(300, 300);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(218, 71);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm!";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.browseFilesButton.Location = new System.Drawing.Point(608, 189);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(109, 46);
            this.browseFilesButton.TabIndex = 2;
            this.browseFilesButton.Text = "Browse";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // filepathButton
            // 
            this.filepathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filepathButton.Location = new System.Drawing.Point(228, 189);
            this.filepathButton.Multiline = true;
            this.filepathButton.Name = "filepathButton";
            this.filepathButton.ReadOnly = true;
            this.filepathButton.Size = new System.Drawing.Size(364, 46);
            this.filepathButton.TabIndex = 3;
            this.filepathButton.Text = "Filepath";
            this.filepathButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filepathButton.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // AddMoodPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filepathButton);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.enterEventText);
            this.Name = "AddMoodPage";
            this.Text = "AddMoodPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterEventText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.TextBox filepathButton;
    }
}