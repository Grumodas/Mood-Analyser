using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryClient.Pages
{
    public partial class LoadingBox : Form
    {
        public LoadingBox()
        {
            InitializeComponent();

            bool dm = Properties.Settings.Default.DarkMode;
            if (dm)
            {
                this.BackColor = Color.DarkSlateGray;
            }
            else
            {
                this.BackColor = Color.Cyan;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        public void SetMessage(String msg)
        {
            text.Text = (msg + " ");
        }

        public void HideLoadText()
        {
            text2.Visible = false;
            text3.Visible = false;
            button.Visible = true;
            dots = false;
        }

        public bool dots = true;
        public void RunLoadingDots()
        {
            string s = "";
            while(dots)
            {
                if(s == "...")
                {
                    s = "";
                } else
                {
                    s += ".";
                }
                text3.Text = s;
                this.Update();
                Thread.Sleep(250);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Click(object sender, EventArgs e)
        {

        }

        private void Text2_Click(object sender, EventArgs e)
        {

        }

        private void Text2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
