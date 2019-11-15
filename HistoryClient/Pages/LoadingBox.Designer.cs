namespace HistoryClient.Pages
{
    partial class LoadingBox
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
            this.text = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Dock = System.Windows.Forms.DockStyle.Left;
            this.text.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Name = "text";
            this.text.Padding = new System.Windows.Forms.Padding(10);
            this.text.Size = new System.Drawing.Size(51, 45);
            this.text.TabIndex = 0;
            this.text.Text = "hi";
            this.text.Click += new System.EventHandler(this.Text_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(5, 136);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(151, 18);
            this.text2.TabIndex = 1;
            this.text2.Text = "Loading. Please wait.";
            // 
            // LoadingBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(397, 165);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingBox";
            this.ShowIcon = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label text2;
    }
}