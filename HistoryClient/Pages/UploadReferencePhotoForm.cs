using AWSLambdaClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryClient
{
    public partial class UploadReferencePhoto : Form
    {

        string path, fileName, fileDir;
        public UploadReferencePhoto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filepathButton_TextChanged(object sender, EventArgs e)
        {

        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            EmotDetector ed = new EmotDetector();
            try
            {
                bool response = await ed.IsReferencePhotoValid(path);

                //if the photo is valid we close this window and proceed to regular menu
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            } catch (InvalidReferencePictureException)
            {
                MessageBox.Show("Invalid photo! Please use a photo which contains only YOUR face!");
            }
        }

        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.PNG; *.JPG)| *.PNG; *.JPG;";
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                path = dialog.FileName; // get name of file
                fileName = Path.GetFileName(path);
                fileDir = path;
                filepathButton.Text = fileName;
            }
        }
    }
}
