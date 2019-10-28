namespace HistoryClient.Pages
{
    partial class MoodForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.moodGroup = new System.Windows.Forms.GroupBox();
            this.unknownBox = new System.Windows.Forms.CheckBox();
            this.fearBox = new System.Windows.Forms.CheckBox();
            this.calmBox = new System.Windows.Forms.CheckBox();
            this.suprisedBox = new System.Windows.Forms.CheckBox();
            this.disgustedBox = new System.Windows.Forms.CheckBox();
            this.confusedBox = new System.Windows.Forms.CheckBox();
            this.angryBox = new System.Windows.Forms.CheckBox();
            this.sadBox = new System.Windows.Forms.CheckBox();
            this.happyBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.moodGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(11, 11);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(248, 269);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // moodGroup
            // 
            this.moodGroup.Controls.Add(this.unknownBox);
            this.moodGroup.Controls.Add(this.fearBox);
            this.moodGroup.Controls.Add(this.calmBox);
            this.moodGroup.Controls.Add(this.suprisedBox);
            this.moodGroup.Controls.Add(this.disgustedBox);
            this.moodGroup.Controls.Add(this.confusedBox);
            this.moodGroup.Controls.Add(this.angryBox);
            this.moodGroup.Controls.Add(this.sadBox);
            this.moodGroup.Controls.Add(this.happyBox);
            this.moodGroup.Location = new System.Drawing.Point(263, 67);
            this.moodGroup.Margin = new System.Windows.Forms.Padding(2);
            this.moodGroup.Name = "moodGroup";
            this.moodGroup.Padding = new System.Windows.Forms.Padding(2);
            this.moodGroup.Size = new System.Drawing.Size(81, 213);
            this.moodGroup.TabIndex = 6;
            this.moodGroup.TabStop = false;
            this.moodGroup.Text = "Mood";
            this.moodGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // unknownBox
            // 
            this.unknownBox.AutoCheck = false;
            this.unknownBox.AutoSize = true;
            this.unknownBox.Location = new System.Drawing.Point(4, 193);
            this.unknownBox.Margin = new System.Windows.Forms.Padding(2);
            this.unknownBox.Name = "unknownBox";
            this.unknownBox.Size = new System.Drawing.Size(72, 17);
            this.unknownBox.TabIndex = 8;
            this.unknownBox.Text = "Unknown";
            this.unknownBox.UseVisualStyleBackColor = true;
            // 
            // fearBox
            // 
            this.fearBox.AutoCheck = false;
            this.fearBox.AutoSize = true;
            this.fearBox.Location = new System.Drawing.Point(4, 171);
            this.fearBox.Margin = new System.Windows.Forms.Padding(2);
            this.fearBox.Name = "fearBox";
            this.fearBox.Size = new System.Drawing.Size(47, 17);
            this.fearBox.TabIndex = 7;
            this.fearBox.Text = "Fear";
            this.fearBox.UseVisualStyleBackColor = true;
            // 
            // calmBox
            // 
            this.calmBox.AutoCheck = false;
            this.calmBox.AutoSize = true;
            this.calmBox.Location = new System.Drawing.Point(4, 149);
            this.calmBox.Margin = new System.Windows.Forms.Padding(2);
            this.calmBox.Name = "calmBox";
            this.calmBox.Size = new System.Drawing.Size(49, 17);
            this.calmBox.TabIndex = 6;
            this.calmBox.Text = "Calm";
            this.calmBox.UseVisualStyleBackColor = true;
            // 
            // suprisedBox
            // 
            this.suprisedBox.AutoCheck = false;
            this.suprisedBox.AutoSize = true;
            this.suprisedBox.Location = new System.Drawing.Point(4, 127);
            this.suprisedBox.Margin = new System.Windows.Forms.Padding(2);
            this.suprisedBox.Name = "suprisedBox";
            this.suprisedBox.Size = new System.Drawing.Size(67, 17);
            this.suprisedBox.TabIndex = 5;
            this.suprisedBox.Text = "Suprised";
            this.suprisedBox.UseVisualStyleBackColor = true;
            // 
            // disgustedBox
            // 
            this.disgustedBox.AutoCheck = false;
            this.disgustedBox.AutoSize = true;
            this.disgustedBox.Location = new System.Drawing.Point(4, 105);
            this.disgustedBox.Margin = new System.Windows.Forms.Padding(2);
            this.disgustedBox.Name = "disgustedBox";
            this.disgustedBox.Size = new System.Drawing.Size(73, 17);
            this.disgustedBox.TabIndex = 4;
            this.disgustedBox.Text = "Disgusted";
            this.disgustedBox.UseVisualStyleBackColor = true;
            // 
            // confusedBox
            // 
            this.confusedBox.AutoCheck = false;
            this.confusedBox.AutoSize = true;
            this.confusedBox.Location = new System.Drawing.Point(4, 83);
            this.confusedBox.Margin = new System.Windows.Forms.Padding(2);
            this.confusedBox.Name = "confusedBox";
            this.confusedBox.Size = new System.Drawing.Size(71, 17);
            this.confusedBox.TabIndex = 3;
            this.confusedBox.Text = "Confused";
            this.confusedBox.UseVisualStyleBackColor = true;
            // 
            // angryBox
            // 
            this.angryBox.AutoCheck = false;
            this.angryBox.AutoSize = true;
            this.angryBox.Location = new System.Drawing.Point(4, 61);
            this.angryBox.Margin = new System.Windows.Forms.Padding(2);
            this.angryBox.Name = "angryBox";
            this.angryBox.Size = new System.Drawing.Size(53, 17);
            this.angryBox.TabIndex = 2;
            this.angryBox.Text = "Angry";
            this.angryBox.UseVisualStyleBackColor = true;
            // 
            // sadBox
            // 
            this.sadBox.AutoCheck = false;
            this.sadBox.AutoSize = true;
            this.sadBox.Location = new System.Drawing.Point(4, 39);
            this.sadBox.Margin = new System.Windows.Forms.Padding(2);
            this.sadBox.Name = "sadBox";
            this.sadBox.Size = new System.Drawing.Size(45, 17);
            this.sadBox.TabIndex = 1;
            this.sadBox.Text = "Sad";
            this.sadBox.UseVisualStyleBackColor = true;
            // 
            // happyBox
            // 
            this.happyBox.AutoCheck = false;
            this.happyBox.AutoSize = true;
            this.happyBox.Location = new System.Drawing.Point(4, 17);
            this.happyBox.Margin = new System.Windows.Forms.Padding(2);
            this.happyBox.Name = "happyBox";
            this.happyBox.Size = new System.Drawing.Size(57, 17);
            this.happyBox.TabIndex = 0;
            this.happyBox.Text = "Happy";
            this.happyBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.happyBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(350, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.moodGroup);
            this.Controls.Add(this.pictureBox);
            this.Name = "MoodForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.moodGroup.ResumeLayout(false);
            this.moodGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox moodGroup;
        private System.Windows.Forms.CheckBox unknownBox;
        private System.Windows.Forms.CheckBox fearBox;
        private System.Windows.Forms.CheckBox calmBox;
        private System.Windows.Forms.CheckBox suprisedBox;
        private System.Windows.Forms.CheckBox disgustedBox;
        private System.Windows.Forms.CheckBox confusedBox;
        private System.Windows.Forms.CheckBox angryBox;
        private System.Windows.Forms.CheckBox sadBox;
        private System.Windows.Forms.CheckBox happyBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveButton;
    }
}