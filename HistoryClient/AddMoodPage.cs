using Amazon.S3;
using Amazon.S3.Model;
using AWSLambdaClient;
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
    public partial class AddMoodPage : Form
    {
        string path, fileName;
        private readonly string accessKey, secretKey;
        public AddMoodPage()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //confirm button
        private void Button1_Click(object sender, EventArgs e)
        {
            String eventName = enterEventText.Text;

            //var client = new AmazonS3Client("AKIAJWYT6DR3ZK454E6Q", " 8lMlWinKEsnOF3H5ipRIxfE4a+J0aIu0B1C2hr7f", Amazon.RegionEndpoint.EUWest2);

            //var putResquest = new PutObjectRequest
            //{
            //    BucketName = "moodanalysis",
            //    Key = fileName,
            //    FilePath = path,
            //    ContentType = "text/plain"
            //};
            EmotDetector ed = new EmotDetector("AKIAJWYT6DR3ZK454E6Q", " 8lMlWinKEsnOF3H5ipRIxfE4a+J0aIu0B1C2hr7f");
            ed.UploadToS3(path, fileName);
        }

        //browse button
        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.PNG; *.JPG)| *.PNG; *.JPG;";
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                path = dialog.FileName; // get name of file
                fileName = Path.GetFileName(path);
                filepathButton.Text = path;
            }
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
