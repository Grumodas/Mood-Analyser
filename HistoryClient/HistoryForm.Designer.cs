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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new HistoryClient.AppData();
            this.bttnBack = new System.Windows.Forms.Button();
            this.tableTableAdapter = new HistoryClient.AppDataTableAdapters.TableTableAdapter();
            this.pictureBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(324, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView.Size = new System.Drawing.Size(945, 180);
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
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(431, 266);
            this.bttnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 30);
            this.bttnBack.TabIndex = 2;
            this.bttnBack.Text = "Go back";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "Photo", true));
            this.pictureBox.Location = new System.Drawing.Point(25, 266);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 270);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
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
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Situation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Situation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // Happy
            // 
            this.Happy.DataPropertyName = "Happy";
            this.Happy.HeaderText = "Happy";
            this.Happy.MinimumWidth = 6;
            this.Happy.Name = "Happy";
            this.Happy.ReadOnly = true;
            this.Happy.Width = 55;
            // 
            // Sad
            // 
            this.Sad.DataPropertyName = "Sad";
            this.Sad.HeaderText = "Sad";
            this.Sad.MinimumWidth = 6;
            this.Sad.Name = "Sad";
            this.Sad.ReadOnly = true;
            this.Sad.Width = 55;
            // 
            // Angry
            // 
            this.Angry.DataPropertyName = "Angry";
            this.Angry.HeaderText = "Angry";
            this.Angry.MinimumWidth = 6;
            this.Angry.Name = "Angry";
            this.Angry.ReadOnly = true;
            this.Angry.Width = 55;
            // 
            // Confused
            // 
            this.Confused.DataPropertyName = "Confused";
            this.Confused.HeaderText = "Confused";
            this.Confused.MinimumWidth = 6;
            this.Confused.Name = "Confused";
            this.Confused.ReadOnly = true;
            this.Confused.Width = 55;
            // 
            // Disgusted
            // 
            this.Disgusted.DataPropertyName = "Disgusted";
            this.Disgusted.HeaderText = "Disgusted";
            this.Disgusted.MinimumWidth = 6;
            this.Disgusted.Name = "Disgusted";
            this.Disgusted.ReadOnly = true;
            this.Disgusted.Width = 55;
            // 
            // Suprised
            // 
            this.Suprised.DataPropertyName = "Suprised";
            this.Suprised.HeaderText = "Suprised";
            this.Suprised.MinimumWidth = 6;
            this.Suprised.Name = "Suprised";
            this.Suprised.ReadOnly = true;
            this.Suprised.Width = 55;
            // 
            // Calm
            // 
            this.Calm.DataPropertyName = "Calm";
            this.Calm.HeaderText = "Calm";
            this.Calm.MinimumWidth = 6;
            this.Calm.Name = "Calm";
            this.Calm.ReadOnly = true;
            this.Calm.Width = 55;
            // 
            // Fear
            // 
            this.Fear.DataPropertyName = "Fear";
            this.Fear.HeaderText = "Fear";
            this.Fear.MinimumWidth = 6;
            this.Fear.Name = "Fear";
            this.Fear.ReadOnly = true;
            this.Fear.Width = 55;
            // 
            // Unknown
            // 
            this.Unknown.DataPropertyName = "Unknown";
            this.Unknown.HeaderText = "Unknown";
            this.Unknown.MinimumWidth = 6;
            this.Unknown.Name = "Unknown";
            this.Unknown.ReadOnly = true;
            this.Unknown.Width = 55;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HistoryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bttnBack;
        private AppData appData;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AppDataTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox;
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
    }
}

#endregion