using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryClient
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.appData.Table);
            // TODO: This line of code loads data into the 'databaseDataSet1.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter1.Fill(this.databaseDataSet1.Table);
            // TODO: This line of code loads data into the 'databaseDataSet1.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter1.Fill(this.databaseDataSet1.Table);
            // TODO: This line of code loads data into the 'databaseDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.databaseDataSet.Table);
            //tableTableAdapter.Update(databaseDataSet.Table);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            //tableTableAdapter.Update(databaseDataSet.Table);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tableTableAdapter1.FillBy(this.databaseDataSet1.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bttnOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
