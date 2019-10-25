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
using System.Text.RegularExpressions;
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

        //CONFIRM (analyse) button
        string fileDir;
        private async void Button1_Click(object sender, EventArgs e)
        {
            string eventNamePattern = @"\w*[a-zA-Z]\w*";

            string eventName = eventText.Text;

            bool isEventNameValid = Regex.IsMatch(eventText.Text, eventNamePattern);

            if (!isEventNameValid)  
            {
                MessageBox.Show("Please enter a valid event name");
            } else
            {
                EmotDetector ed = new EmotDetector("AKIAJD7LAUG64Y5KY3SA", "CKX8DTED/dvNbYtORQf5sdeK747bEz1kJgT1aIUG");
                //await ed.UploadToS3(path, fileName);
                string emotions = await ed.WhatEmot(path, fileName) + "";
                //message = message.Replace('\n', );
                emotions = emotions.Replace("\"", "");
                //MessageBox.Show(emotions);

                //creating enum
                Emotion emos = new Emotion();
                int i = 0;
                string[] emotionArray = emotions.Split(',');
                //foreach uzkomentintas nes man kazkas bug'ina su juo
                foreach (var emotion in emotionArray)
                {
                    if (i == 0)
                    {
                        emos = (Emotion)Enum.Parse(typeof(Emotion), emotion);
                        i++;
                    }
                    else
                    {
                        emos = emos | (Emotion)Enum.Parse(typeof(Emotion), emotion);
                    }

                }

                string binaryEmotions = Convert.ToString((int)emos, 2);
                MessageBox.Show("Emotions detected: " + emotions);

                Byte[] ImageToByteArray(System.Drawing.Image imageIn)
                {
                    using (var ms = new MemoryStream())
                    {
                        imageIn.Save(ms, imageIn.RawFormat);
                        return ms.ToArray();
                    }
                }

                //Image img = Image.FromFile(filepathButton.Text);

                Byte[] image = null;
                image = File.ReadAllBytes(fileDir);
                PhotoInfo photoInfo = new PhotoInfo();
                this.tableTableAdapter.Insert(photoInfo, emos.HasFlag(Emotion.HAPPY),
                                                                            emos.HasFlag(Emotion.SAD),
                                                                            emos.HasFlag(Emotion.ANGRY),
                                                                            emos.HasFlag(Emotion.CONFUSED),
                                                                            emos.HasFlag(Emotion.DISGUSTED),
                                                                            emos.HasFlag(Emotion.SURPRISED),
                                                                            emos.HasFlag(Emotion.CALM),
                                                                            emos.HasFlag(Emotion.FEAR),
                                                                            emos.HasFlag(Emotion.UNKNOWN),
                                                                            image);
                //this.tableTableAdapter.Insert(photoInfo, image);
                this.tableTableAdapter.Update(this.appData.Table);


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                fileDir = path;
                filepathButton.Text = fileName;
            }
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
