namespace HistoryClient.Pages
{
    partial class InvitationReuploadRefPhotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvitationReuploadRefPhotoForm));
            this.infoAboutRefPhoto = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoAboutRefPhoto
            // 
            this.infoAboutRefPhoto.Location = new System.Drawing.Point(53, 19);
            this.infoAboutRefPhoto.Name = "infoAboutRefPhoto";
            this.infoAboutRefPhoto.Size = new System.Drawing.Size(258, 85);
            this.infoAboutRefPhoto.TabIndex = 0;
            this.infoAboutRefPhoto.Text = "Oopsie! It seems like we can\'t quite \r\nlocate you in your photos. \r\n\r\nWould you l" +
    "ike to reupload\r\nyour reference picture?";
            this.infoAboutRefPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infoAboutRefPhoto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.confirmButton.Location = new System.Drawing.Point(67, 121);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(87, 35);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Yup";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(199, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nope";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvitationReuploadRefPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.infoAboutRefPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvitationReuploadRefPhotoForm";
            this.Text = "Can\'t locate you";
            this.Load += new System.EventHandler(this.InvitationReuploadRefPhotoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoAboutRefPhoto;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button button1;
    }
}