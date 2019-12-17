using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryClient.Pages
{
    public partial class InvitationReuploadRefPhotoForm : Form
    {
        public delegate void ThreeUnknownsInaRow(object sender, MultipleUnknownPhotosEventArgs e);
        public event ThreeUnknownsInaRow PossiblyBadReferencePicture;
        public int howManyUnknownsInaRow;

        public InvitationReuploadRefPhotoForm()
        {
            InitializeComponent();

            bool dm = Properties.Settings.Default.DarkMode;
            if (dm)
            {
                this.BackColor = Color.DarkSlateGray;
            }
            else
            {
                this.BackColor = Color.FromArgb(146, 183, 254);
            }
        }

        public InvitationReuploadRefPhotoForm(int howManyUnknownsInaRow)
        {
            InitializeComponent();
            this.howManyUnknownsInaRow = howManyUnknownsInaRow;

            infoAboutRefPhoto.Text = "Oopsie! It seems like we couldn't quite "
                                    + "locate you in the last " + howManyUnknownsInaRow + " photos."
                                    + '\n'
                                    + "Would you like to reupload"
                                    + " your reference picture?";
            //"hello test " + howManyUnknownsInaRow;

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var reuploadRefForm = new UploadReferencePhoto();
            reuploadRefForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvitationReuploadRefPhotoForm_Load(object sender, EventArgs e)
        {

        }

        //public void reuploadRefPhoto(object sender, MultipleUnknownPhotosEventArgs e)
        //{

        //}
    }
}
