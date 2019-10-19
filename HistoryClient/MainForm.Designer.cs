namespace HistoryClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.newRecordButton = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.moodAnalyzerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // newRecordButton
            // 
            this.newRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.newRecordButton.Location = new System.Drawing.Point(100, 180);
            this.newRecordButton.Name = "newRecordButton";
            this.newRecordButton.Size = new System.Drawing.Size(175, 50);
            this.newRecordButton.TabIndex = 0;
            this.newRecordButton.Text = "New Record";
            this.newRecordButton.UseVisualStyleBackColor = true;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonHistory.Location = new System.Drawing.Point(325, 180);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(175, 50);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.button2_Click);
            // 
            // Icon
            // 
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.Location = new System.Drawing.Point(225, 10);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(150, 120);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 2;
            this.Icon.TabStop = false;
            // 
            // moodAnalyzerLabel
            // 
            this.moodAnalyzerLabel.AutoSize = true;
            this.moodAnalyzerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.moodAnalyzerLabel.Location = new System.Drawing.Point(167, 140);
            this.moodAnalyzerLabel.Name = "moodAnalyzerLabel";
            this.moodAnalyzerLabel.Size = new System.Drawing.Size(268, 32);
            this.moodAnalyzerLabel.TabIndex = 3;
            this.moodAnalyzerLabel.Text = "Mood Analyzer 1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.moodAnalyzerLabel);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.newRecordButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRecordButton;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label moodAnalyzerLabel;
    }
}