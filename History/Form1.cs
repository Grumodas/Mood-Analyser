using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History
{
    public partial class Form1 : Form
    {
        DataTable historyTable;
        //


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.appData.Table);
            //historyTable = new DataTable();
            //historyTable.Columns.Add("Date", typeof(DateTime));
            //historyTable.Columns.Add("Event", typeof(String));

            //dataGridView.DataSource = historyTable;
        }

        private void bttnOpen_Click(object sender, EventArgs e)
        {
            //Table.Update(appData.Table);
            //historyTable.Rows.Add(textBox.Text);
            //textBox.Clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
