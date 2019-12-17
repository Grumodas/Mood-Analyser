using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;
using Android.Views;
using Java.IO;
using System.Drawing;
using Android.Graphics;
using AndroidXamarin.Activities;
using AWSLambdaClient;
using System.IO;
using Android.Database;
using Android.Provider;

namespace AndroidXamarin
{
    // uncomment line below to set activity to launch activity
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]

    public class MainActivity : AppCompatActivity
    {
        Button uploadRefPhotoButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            uploadRefPhotoButton = FindViewById<Button>(Resource.Id.UploadRefPhotoButton);
            uploadRefPhotoButton.Click += this.ChooseRefPhoto;

            var confirmButton = FindViewById<Button>(Resource.Id.confirmButton);
            confirmButton.Click += delegate
            {
                Toast.MakeText(this, "NICE PHOTO LOL", ToastLength.Short).Show();

                var intent = new Intent(this, typeof(UploadNewPhotoActivity));
                StartActivity(intent);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        }

        void ChooseRefPhoto(object sender, EventArgs args)
        {
            var imageIntent = new Intent();
            imageIntent.SetType("image/*");
            imageIntent.SetAction(Intent.ActionGetContent);
            StartActivityForResult(
            Intent.CreateChooser(imageIntent, "Select photo"), 0);


        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {

                var imageView = FindViewById<ImageView>(Resource.Id.selectedPhotoView);
                imageView.SetImageURI(data.Data);

                //prepare for analysis    
                string path = Android.OS.Environment.GetExternalStoragePublicDirectory(
                  Android.OS.Environment.DirectoryPictures).AbsolutePath;
                string myPath = data.Data.Path;
                //EmotDetector ed = new EmotDetector();

                Android.Net.Uri uri = data.Data;
                Stream stream = ContentResolver.OpenInputStream(uri);

                string filepath = GetFilePath(uri);

                EmotDetector ed = new EmotDetector();
                ed.uploadPhotoAndroid(filepath);
                Toast.MakeText(this, filepath, ToastLength.Short).Show();
            }

            string GetFilePath(Android.Net.Uri uri)
            {
                string filePath = "";
                //             
                string imageId = DocumentsContract.GetDocumentId(uri);
                string id = imageId.Split(':')[1];
                string[] proj = { MediaStore.Images.Media.InterfaceConsts.Data };
                string sel = MediaStore.Images.Media.InterfaceConsts.Id + "=?";

                using (ICursor cursor = ContentResolver.Query(MediaStore.Images.Media.ExternalContentUri, proj, sel, new string[] { id }, null))
                {
                    int columnIndex = cursor.GetColumnIndex(proj[0]);
                    if (cursor.MoveToFirst())
                    {
                        filePath = cursor.GetString(columnIndex);
                    }
                }
                return filePath;


            }
        }
    }
}