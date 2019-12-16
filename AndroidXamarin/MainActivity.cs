using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace AndroidXamarin
{
    // uncomment line below to set activity to launch activity
   // [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]

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

            Toast.MakeText(this, "NICE PHOTO BRO WAIT THIS SHOULD BE SHOWN LATER SORRY", ToastLength.Short).Show();

            //var intent = new Intent(this, typeof(UploadNewPhotoActivity));
            ////intent.PutExtra("DATA_PASS", txtdatapass.Text); //DATA_PASS is Identify the Value Pass variable  
            //this.StartActivity(intent);


        }

        //protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        //{
        //    base.OnActivityResult(requestCode, resultCode, data);

        //    if (resultCode == Result.Ok)
        //    {
        //        var intent = new Intent(this, typeof(UploadNewPhotoActivity));
        //        //intent.PutExtra("DATA_PASS", txtdatapass.Text); //DATA_PASS is Identify the Value Pass variable  
        //        this.StartActivity(intent);
        //    }
        //}

    }
}