namespace History
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.bttnOpen = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox = new System.Windows.Forms.TextBox();
            //this.appData = new History.AppData();
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.tableTableAdapter = new History.AppDataTableAdapters.TableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Title.Location = new System.Drawing.Point(334, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(152, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "History";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bttnOpen
            // 
            this.bttnOpen.Location = new System.Drawing.Point(50, 400);
            this.bttnOpen.Name = "bttnOpen";
            this.bttnOpen.Size = new System.Drawing.Size(75, 27);
            this.bttnOpen.TabIndex = 2;
            this.bttnOpen.Text = "Open";
            this.bttnOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnOpen.UseVisualStyleBackColor = true;
            this.bttnOpen.Click += new System.EventHandler(this.bttnOpen_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.situationDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tableBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(50, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(700, 280);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // textBox
            // 
            this.textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Situation", true));
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox.Location = new System.Drawing.Point(180, 400);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(151, 27);
            this.textBox.TabIndex = 4;
            // 
            // appData
            // 
            //this.appData.DataSetName = "AppData";
            //this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appDataBindingSource
            // 
            //this.appDataBindingSource.DataSource = this.appData;
            //this.appDataBindingSource.Position = 0;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.appDataBindingSource;
            // 
            // tableTableAdapter
            // 
            //this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // situationDataGridViewTextBoxColumn
            // 
            this.situationDataGridViewTextBoxColumn.DataPropertyName = "Situation";
            this.situationDataGridViewTextBoxColumn.HeaderText = "Situation";
            this.situationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.situationDataGridViewTextBoxColumn.Name = "situationDataGridViewTextBoxColumn";
            this.situationDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bttnOpen);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button bttnOpen;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        //private AppData appData;
        private System.Windows.Forms.BindingSource tableBindingSource;
        //private AppDataTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situationDataGridViewTextBoxColumn;
    }
}

