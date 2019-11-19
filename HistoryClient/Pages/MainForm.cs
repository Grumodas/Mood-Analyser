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
    public partial class MainForm : Form
    {
        bool dm;
        public MainForm()
        {
            InitializeComponent();

            dm = Properties.Settings.Default.DarkMode;
            if (dm)
            {
                this.BackColor = Color.DarkSlateGray;
            }
            else
            {
                this.BackColor = Color.Cyan;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.appData.Table);
        }

        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            AddMoodPage addMoodPage = new AddMoodPage();
            addMoodPage.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dm = Properties.Settings.Default.DarkMode;
            if (dm)
            {
                this.BackColor = Color.Cyan;
                Properties.Settings.Default.DarkMode = false;
            }
            else
            {
                this.BackColor = Color.DarkSlateGray;
                Properties.Settings.Default.DarkMode = true;
                
            }
        }

        private void MoodAnalyzerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
