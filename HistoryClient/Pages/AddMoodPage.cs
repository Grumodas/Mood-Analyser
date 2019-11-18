using Amazon.S3;
using Amazon.S3.Model;
using AWSLambdaClient;
using HistoryClient.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryClient
{
    public partial class AddMoodPage : Form
    {
        public delegate void ThreeUnknownsInaRow(object sender, MultipleUnknownPhotosEventArgs e);
        public event ThreeUnknownsInaRow PossiblyBadReferencePicture;

        string path, fileName;
        private readonly string accessKey = "AKIAJD7LAUG64Y5KY3SA", 
            secretKey = "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";
        public AddMoodPage()
        {
            InitializeComponent();
            PossiblyBadReferencePicture += new ThreeUnknownsInaRow(MultipleUnknownsHandler.InviteReuploadRefPhoto);
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

            string eventName = StringChanger.ChangeFirstLetterCase(eventText.Text);

            bool isEventNameValid = Regex.IsMatch(eventText.Text, eventNamePattern);

            if (!isEventNameValid)  
            {
                MessageBox.Show("Please enter a valid event name");
            } else
            {
                confirmButton.Enabled = false;
                LoadingScreen ls = new LoadingScreen();
                ls.Open();

                EmotDetector ed = new EmotDetector();
                //await ed.UploadToS3(path, fileName);
                string emotions = await ed.WhatEmot(path, fileName) + "";
                
                emotions = emotions.Replace("\"", "");
                //MessageBox.Show(emotions);

                //creating enum
                Emotion emos = new Emotion();
                int i = 0;
                string[] emotionArray = emotions.Split(',');

                if (emotionArray[0] == "")
                {
                    emos = Emotion.UNKNOWN;
                    emotions = "UNKNOWN";
                } else
                {
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
                }   

                string binaryEmotions = Convert.ToString((int)emos, 2);
                ls.setEmotions(emotions);
                //MessageBox.Show("Emotions detected: " + emotions);

                Byte[] image = null;
                image = File.ReadAllBytes(fileDir);
                //PhotoInfo photoInfo = new PhotoInfo(eventName, emos);
                Info info = new Info(eventName, emos);
                IEquatable<Info> narrow = info; 
                if (Info.index > 1)
                {
                    Info lastInfo = info[Info.index - 2];

                    //if (lastInfo.CompareTo(info) > 0)
                    //{
                    //    MessageBox.Show("everything good");
                    //}

                    if (!narrow.Equals(lastInfo))
                    {
                        this.tableTableAdapter.Insert(info, image);
                        this.tableTableAdapter.Update(this.appData.Table);
                    }
                    else
                    {
                        MessageBox.Show("Event already uploaded");
                    }
                } else
                {
                    this.tableTableAdapter.Insert(info, image);
                    this.tableTableAdapter.Update(this.appData.Table);
                }

                ls.WaitForClose();
                confirmButton.Enabled = true;

                if (Info.index > 2)
                {
                    Info infoCurrent = info[Info.index - 1];

                    if (infoCurrent.emotion == 0 &&
                        info[Info.index - 2].emotion == 0 &&
                        info[Info.index - 3].emotion == 0)
                    {
                        int counter = 1;
                        for (int n = Info.index - counter; n >= 0 && info[n].emotion == 0; n--)
                        {
                            counter++;
                        }

                        MultipleUnknownPhotosEventArgs arg = new MultipleUnknownPhotosEventArgs(counter - 1);
                        PossiblyBadReferencePicture(this, arg);
                    }
                    //MessageBox.Show(info[0].eventName + '\n' +
                    //    info[1].eventName + '\n' +
                    //    info[2].eventName);
                }
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
