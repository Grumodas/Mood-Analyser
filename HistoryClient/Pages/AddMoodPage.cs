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
        public delegate void ThreeUnknownsInaRow<EventArgs>(MultipleUnknownPhotosEventArgs e);
        //public delegate Action<EventArgs> ThreeUnknownsInaRow(MultipleUnknownPhotosEventArgs e);
        public event ThreeUnknownsInaRow<EventArgs> PossiblyBadReferencePicture;

        public delegate void IsDublicateBoxChecked(object sender, EventArgs e);
        public event IsDublicateBoxChecked PossiblyDublicateUploads;

        string path, fileName;
        public AddMoodPage()
        {
            InitializeComponent();
            PossiblyBadReferencePicture += new ThreeUnknownsInaRow<EventArgs>(MultipleUnknownsHandler.InviteReuploadRefPhoto);
            PossiblyDublicateUploads += new IsDublicateBoxChecked(CheckForDublicateEventHandler.CheckIfDublicate);
            dublicateBox.Checked = false;

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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //CONFIRM (analyse) button
        string fileDir;

        private void GenError<T>(T val)
        {
            MessageBox.Show(val.ToString());
        }

        public delegate T add<T>(T param1, T param2);

        public static int AddNumber(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concate(string str1, string str2)
        {
            return str1 + str2;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string value = System.Configuration.ConfigurationManager.AppSettings["eventName"];
            string eventNamePattern;
            //MessageBox.Show("val is: " + value + " much");
            if (value == "text")
            {
                eventNamePattern = @"\w*[a-zA-Z]\w*";
            }
            else
            {
                eventNamePattern = "(.*?)";
            }

            string eventName = StringChanger.ChangeFirstLetterCase(eventText.Text);

            bool isEventNameValid = Regex.IsMatch(eventText.Text, eventNamePattern);

            if (!isEventNameValid)  
            {
                add<string> conct = Concate;
                GenError<string>(conct("Please enter a valid event name, you entered - ", eventText.Text));
                //MessageBox.Show("Please enter a valid event name");
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
                            add<int> sum = AddNumber;
                            i = sum(i, 1);
                            //i++;
                        }
                        else
                        {
                            emos = emos | (Emotion)Enum.Parse(typeof(Emotion), emotion);
                        
                        }
                    }
                }   

                string binaryEmotions = Convert.ToString((int)emos, 2);
                ls.setEmotions(emotions);

                Byte[] image = File.ReadAllBytes(fileDir);
                Info info = new Info(eventName, emos);
                IEquatable<Info> narrow = info; 
                if (Info.index > 1 && dublicateBox.Checked)
                {
                    EventArgs arg = new EventArgs();
                    PossiblyDublicateUploads(this, arg);
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
                        PossiblyBadReferencePicture(arg);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (dublicateBox.Checked)
            //{
            //    dublicateBox.Text = "Checked";
            //}
            //else
            //{
            //    dublicateBox.Text = "Unchecked";
            //}
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
