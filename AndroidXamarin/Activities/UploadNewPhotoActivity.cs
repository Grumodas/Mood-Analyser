using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidXamarin
{
    [Activity(Label = "UploadNewPhotoActivity")]
    public class UploadNewPhotoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_upload_new_photo);
            Button uploadPhotoButton = FindViewById<Button>(Resource.Id.uploadPhotoButton);

            uploadPhotoButton.Click += delegate
             {
                 var imageIntent = new Intent();
                 imageIntent.SetType("image/*");
                 imageIntent.SetAction(Intent.ActionGetContent);
                 StartActivityForResult(
                     Intent.CreateChooser(imageIntent, "Select photo"), 0);
             };

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {

                var imageView = FindViewById<ImageView>(Resource.Id.selectedPhotoView);
                imageView.SetImageURI(data.Data);

                var confirmButton = FindViewById<Button>(Resource.Id.confirmButton);
                confirmButton.Visibility = ViewStates.Visible;
            }
        }
    }


} 

