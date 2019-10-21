namespace HistoryClient
{
    partial class HistoryForm
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
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.historyLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new HistoryClient.AppData();
            this.tableTableAdapter = new HistoryClient.AppDataTableAdapters.TableTableAdapter();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.happyBox = new System.Windows.Forms.CheckBox();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Happy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Angry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Confused = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Disgusted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Suprised = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Calm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fear = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Unknown = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sadBox = new System.Windows.Forms.CheckBox();
            this.angryBox = new System.Windows.Forms.CheckBox();
            this.confusedBox = new System.Windows.Forms.CheckBox();
            this.disgustedBox = new System.Windows.Forms.CheckBox();
            this.suprisedBox = new System.Windows.Forms.CheckBox();
            this.calmBox = new System.Windows.Forms.CheckBox();
            this.fearBox = new System.Windows.Forms.CheckBox();
            this.unknownBox = new System.Windows.Forms.CheckBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.situationLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.historyLabel.Location = new System.Drawing.Point(341, 20);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(152, 46);
            this.historyLabel.TabIndex = 0;
            this.historyLabel.Text = "History";
            this.historyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Photo,
            this.Id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Happy,
            this.Sad,
            this.Angry,
            this.Confused,
            this.Disgusted,
            this.Suprised,
            this.Calm,
            this.Fear,
            this.Unknown});
            this.dataGridView.DataSource = this.tableBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(25, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(330, 330);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "Photo", true));
            this.pictureBox.Location = new System.Drawing.Point(361, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(330, 330);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unknownBox);
            this.groupBox1.Controls.Add(this.fearBox);
            this.groupBox1.Controls.Add(this.calmBox);
            this.groupBox1.Controls.Add(this.suprisedBox);
            this.groupBox1.Controls.Add(this.disgustedBox);
            this.groupBox1.Controls.Add(this.confusedBox);
            this.groupBox1.Controls.Add(this.angryBox);
            this.groupBox1.Controls.Add(this.sadBox);
            this.groupBox1.Controls.Add(this.happyBox);
            this.groupBox1.Location = new System.Drawing.Point(697, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mood";
            // 
            // happyBox
            // 
            this.happyBox.AutoCheck = false;
            this.happyBox.AutoSize = true;
            this.happyBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckAlign", this.tableBindingSource, "Happy", true));
            this.happyBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Happy", true));
            this.happyBox.Location = new System.Drawing.Point(6, 21);
            this.happyBox.Name = "happyBox";
            this.happyBox.Size = new System.Drawing.Size(71, 21);
            this.happyBox.TabIndex = 0;
            this.happyBox.Text = "Happy";
            this.happyBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.happyBox.UseVisualStyleBackColor = true;
            this.happyBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "Photo";
            this.Photo.MinimumWidth = 6;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Visible = false;
            this.Photo.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date & Time";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date & Time";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Situation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Situation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Happy
            // 
            this.Happy.DataPropertyName = "Happy";
            this.Happy.HeaderText = "Happy";
            this.Happy.MinimumWidth = 6;
            this.Happy.Name = "Happy";
            this.Happy.ReadOnly = true;
            this.Happy.Visible = false;
            this.Happy.Width = 55;
            // 
            // Sad
            // 
            this.Sad.DataPropertyName = "Sad";
            this.Sad.HeaderText = "Sad";
            this.Sad.MinimumWidth = 6;
            this.Sad.Name = "Sad";
            this.Sad.ReadOnly = true;
            this.Sad.Visible = false;
            this.Sad.Width = 55;
            // 
            // Angry
            // 
            this.Angry.DataPropertyName = "Angry";
            this.Angry.HeaderText = "Angry";
            this.Angry.MinimumWidth = 6;
            this.Angry.Name = "Angry";
            this.Angry.ReadOnly = true;
            this.Angry.Visible = false;
            this.Angry.Width = 55;
            // 
            // Confused
            // 
            this.Confused.DataPropertyName = "Confused";
            this.Confused.HeaderText = "Confused";
            this.Confused.MinimumWidth = 6;
            this.Confused.Name = "Confused";
            this.Confused.ReadOnly = true;
            this.Confused.Visible = false;
            this.Confused.Width = 55;
            // 
            // Disgusted
            // 
            this.Disgusted.DataPropertyName = "Disgusted";
            this.Disgusted.HeaderText = "Disgusted";
            this.Disgusted.MinimumWidth = 6;
            this.Disgusted.Name = "Disgusted";
            this.Disgusted.ReadOnly = true;
            this.Disgusted.Visible = false;
            this.Disgusted.Width = 55;
            // 
            // Suprised
            // 
            this.Suprised.DataPropertyName = "Suprised";
            this.Suprised.HeaderText = "Suprised";
            this.Suprised.MinimumWidth = 6;
            this.Suprised.Name = "Suprised";
            this.Suprised.ReadOnly = true;
            this.Suprised.Visible = false;
            this.Suprised.Width = 55;
            // 
            // Calm
            // 
            this.Calm.DataPropertyName = "Calm";
            this.Calm.HeaderText = "Calm";
            this.Calm.MinimumWidth = 6;
            this.Calm.Name = "Calm";
            this.Calm.ReadOnly = true;
            this.Calm.Visible = false;
            this.Calm.Width = 55;
            // 
            // Fear
            // 
            this.Fear.DataPropertyName = "Fear";
            this.Fear.HeaderText = "Fear";
            this.Fear.MinimumWidth = 6;
            this.Fear.Name = "Fear";
            this.Fear.ReadOnly = true;
            this.Fear.Visible = false;
            this.Fear.Width = 55;
            // 
            // Unknown
            // 
            this.Unknown.DataPropertyName = "Unknown";
            this.Unknown.HeaderText = "Unknown";
            this.Unknown.MinimumWidth = 6;
            this.Unknown.Name = "Unknown";
            this.Unknown.ReadOnly = true;
            this.Unknown.Visible = false;
            this.Unknown.Width = 55;
            // 
            // sadBox
            // 
            this.sadBox.AutoCheck = false;
            this.sadBox.AutoSize = true;
            this.sadBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Sad", true));
            this.sadBox.Location = new System.Drawing.Point(6, 48);
            this.sadBox.Name = "sadBox";
            this.sadBox.Size = new System.Drawing.Size(55, 21);
            this.sadBox.TabIndex = 1;
            this.sadBox.Text = "Sad";
            this.sadBox.UseVisualStyleBackColor = true;
            // 
            // angryBox
            // 
            this.angryBox.AutoCheck = false;
            this.angryBox.AutoSize = true;
            this.angryBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Angry", true));
            this.angryBox.Location = new System.Drawing.Point(6, 75);
            this.angryBox.Name = "angryBox";
            this.angryBox.Size = new System.Drawing.Size(67, 21);
            this.angryBox.TabIndex = 2;
            this.angryBox.Text = "Angry";
            this.angryBox.UseVisualStyleBackColor = true;
            // 
            // confusedBox
            // 
            this.confusedBox.AutoCheck = false;
            this.confusedBox.AutoSize = true;
            this.confusedBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Confused", true));
            this.confusedBox.Location = new System.Drawing.Point(6, 102);
            this.confusedBox.Name = "confusedBox";
            this.confusedBox.Size = new System.Drawing.Size(90, 21);
            this.confusedBox.TabIndex = 3;
            this.confusedBox.Text = "Confused";
            this.confusedBox.UseVisualStyleBackColor = true;
            // 
            // disgustedBox
            // 
            this.disgustedBox.AutoCheck = false;
            this.disgustedBox.AutoSize = true;
            this.disgustedBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Disgusted", true));
            this.disgustedBox.Location = new System.Drawing.Point(6, 129);
            this.disgustedBox.Name = "disgustedBox";
            this.disgustedBox.Size = new System.Drawing.Size(93, 21);
            this.disgustedBox.TabIndex = 4;
            this.disgustedBox.Text = "Disgusted";
            this.disgustedBox.UseVisualStyleBackColor = true;
            // 
            // suprisedBox
            // 
            this.suprisedBox.AutoCheck = false;
            this.suprisedBox.AutoSize = true;
            this.suprisedBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Suprised", true));
            this.suprisedBox.Location = new System.Drawing.Point(6, 156);
            this.suprisedBox.Name = "suprisedBox";
            this.suprisedBox.Size = new System.Drawing.Size(86, 21);
            this.suprisedBox.TabIndex = 5;
            this.suprisedBox.Text = "Suprised";
            this.suprisedBox.UseVisualStyleBackColor = true;
            // 
            // calmBox
            // 
            this.calmBox.AutoCheck = false;
            this.calmBox.AutoSize = true;
            this.calmBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Calm", true));
            this.calmBox.Location = new System.Drawing.Point(6, 183);
            this.calmBox.Name = "calmBox";
            this.calmBox.Size = new System.Drawing.Size(61, 21);
            this.calmBox.TabIndex = 6;
            this.calmBox.Text = "Calm";
            this.calmBox.UseVisualStyleBackColor = true;
            // 
            // fearBox
            // 
            this.fearBox.AutoCheck = false;
            this.fearBox.AutoSize = true;
            this.fearBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Fear", true));
            this.fearBox.Location = new System.Drawing.Point(6, 210);
            this.fearBox.Name = "fearBox";
            this.fearBox.Size = new System.Drawing.Size(59, 21);
            this.fearBox.TabIndex = 7;
            this.fearBox.Text = "Fear";
            this.fearBox.UseVisualStyleBackColor = true;
            // 
            // unknownBox
            // 
            this.unknownBox.AutoCheck = false;
            this.unknownBox.AutoSize = true;
            this.unknownBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Unknown", true));
            this.unknownBox.Location = new System.Drawing.Point(6, 237);
            this.unknownBox.Name = "unknownBox";
            this.unknownBox.Size = new System.Drawing.Size(88, 21);
            this.unknownBox.TabIndex = 8;
            this.unknownBox.Text = "Unknown";
            this.unknownBox.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(25, 57);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 17);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date Time";
            this.dateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // situationLabel
            // 
            this.situationLabel.AutoSize = true;
            this.situationLabel.Location = new System.Drawing.Point(153, 57);
            this.situationLabel.Name = "situationLabel";
            this.situationLabel.Size = new System.Drawing.Size(63, 17);
            this.situationLabel.TabIndex = 7;
            this.situationLabel.Text = "Situation";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.deleteButton.Location = new System.Drawing.Point(703, 349);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 38);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Clear History";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 428);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.situationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.historyLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HistoryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private AppData appData;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AppDataTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox happyBox;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Happy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Angry;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Confused;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disgusted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Suprised;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Calm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Fear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Unknown;
        private System.Windows.Forms.CheckBox unknownBox;
        private System.Windows.Forms.CheckBox fearBox;
        private System.Windows.Forms.CheckBox calmBox;
        private System.Windows.Forms.CheckBox suprisedBox;
        private System.Windows.Forms.CheckBox disgustedBox;
        private System.Windows.Forms.CheckBox confusedBox;
        private System.Windows.Forms.CheckBox angryBox;
        private System.Windows.Forms.CheckBox sadBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label situationLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}

#endregion