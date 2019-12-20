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
    [Activity(Label = "MainActivity"/*, Theme = "@style/AppTheme", MainLauncher = true*/)]

    public class MainActivity : AppCompatActivity
    {
        Button uploadRefPhotoButton;
        Button confirmButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //what's this?
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            uploadRefPhotoButton = FindViewById<Button>(Resource.Id.add_ref_upload);
            confirmButton = FindViewById<Button>(Resource.Id.add_ref_confirm);
            confirmButton.Visibility = ViewStates.Visible;
            uploadRefPhotoButton.Click += this.ChooseRefPhoto;

            confirmButton.Click += delegate
            {
                Toast.MakeText(this, "NICE PHOTO LOL", ToastLength.Short).Show();
                CurrentUser.has_ref_photo = true;
                var intent = new Intent(this, typeof(MainMenuFormActivity));
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

                ImageView imageView = FindViewById<ImageView>(Resource.Id.add_ref_image);
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
        /*
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {
                Android.Graphics.Bitmap img_src = MediaStore.Images.Media.GetBitmap(this.ContentResolver, data.Data);
                // Paema tikra path
                img_path = GetActualPathFromFile(data.Data);

                // Teisingai pasuka ir ikelia
                ExifInterface exif = new ExifInterface(img_path);
                int rot = exif.GetAttributeInt(ExifInterface.TagOrientation, (int)Android.Media.Orientation.Normal);
                int rot_deg = exifToDegrees(rot);
                Matrix mat = new Matrix();
                if (rot != 0)
                {
                    mat.PreRotate(rot_deg);
                }
                bm = Android.Graphics.Bitmap.CreateBitmap(img_src, 0, 0, img_src.Width, img_src.Height, mat, true);
                image.SetImageBitmap(bm);

                confirm.Visibility = ViewStates.Visible;
            }
        }
        */
        private byte[] BitToByte(Android.Graphics.Bitmap bitm)
        {
            byte[] bitmapData;
            using (var stream = new MemoryStream())
            {
                bitm.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 0, stream);
                bitmapData = stream.ToArray();
            }

            return bitmapData;
        }

        //Don't understand code very well
        private string GetActualPathFromFile(Android.Net.Uri uri)
        {
            bool isKitKat = Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Kitkat;

            if (isKitKat && DocumentsContract.IsDocumentUri(this, uri))
            {
                // ExternalStorageProvider
                if (isExternalStorageDocument(uri))
                {
                    string docId = DocumentsContract.GetDocumentId(uri);

                    char[] chars = { ':' };
                    string[] split = docId.Split(chars);
                    string type = split[0];

                    if ("primary".Equals(type, StringComparison.OrdinalIgnoreCase))
                    {
                        return Android.OS.Environment.ExternalStorageDirectory + "/" + split[1];
                    }
                }
                // DownloadsProvider
                else if (isDownloadsDocument(uri))
                {
                    string id = DocumentsContract.GetDocumentId(uri);

                    Android.Net.Uri contentUri = ContentUris.WithAppendedId(
                                    Android.Net.Uri.Parse("content://downloads/public_downloads"), long.Parse(id));

                    return getDataColumn(this, contentUri, null, null);
                }
                // MediaProvider
                else if (isMediaDocument(uri))
                {
                    String docId = DocumentsContract.GetDocumentId(uri);

                    char[] chars = { ':' };
                    String[] split = docId.Split(chars);

                    String type = split[0];

                    Android.Net.Uri contentUri = null;
                    if ("image".Equals(type))
                    {
                        contentUri = MediaStore.Images.Media.ExternalContentUri;
                    }
                    else if ("video".Equals(type))
                    {
                        contentUri = MediaStore.Video.Media.ExternalContentUri;
                    }
                    else if ("audio".Equals(type))
                    {
                        contentUri = MediaStore.Audio.Media.ExternalContentUri;
                    }

                    String selection = "_id=?";
                    String[] selectionArgs = new String[]
                    {
                        split[1]
                    };

                    return getDataColumn(this, contentUri, selection, selectionArgs);
                }
            }
            // MediaStore (and general)
            else if ("content".Equals(uri.Scheme, StringComparison.OrdinalIgnoreCase))
            {

                // Return the remote address
                if (isGooglePhotosUri(uri))
                    return uri.LastPathSegment;

                return getDataColumn(this, uri, null, null);
            }
            // File
            else if ("file".Equals(uri.Scheme, StringComparison.OrdinalIgnoreCase))
            {
                return uri.Path;
            }

            return null;
        }

        public static String getDataColumn(Context context, Android.Net.Uri uri, String selection, String[] selectionArgs)
        {
            ICursor cursor = null;
            String column = "_data";
            String[] projection =
            {
                column
            };

            try
            {
                cursor = context.ContentResolver.Query(uri, projection, selection, selectionArgs, null);
                if (cursor != null && cursor.MoveToFirst())
                {
                    int index = cursor.GetColumnIndexOrThrow(column);
                    return cursor.GetString(index);
                }
            }
            finally
            {
                if (cursor != null)
                    cursor.Close();
            }
            return null;
        }

        //Whether the Uri authority is ExternalStorageProvider.
        public static bool isExternalStorageDocument(Android.Net.Uri uri)
        {
            return "com.android.externalstorage.documents".Equals(uri.Authority);
        }

        //Whether the Uri authority is DownloadsProvider.
        public static bool isDownloadsDocument(Android.Net.Uri uri)
        {
            return "com.android.providers.downloads.documents".Equals(uri.Authority);
        }

        //Whether the Uri authority is MediaProvider.
        public static bool isMediaDocument(Android.Net.Uri uri)
        {
            return "com.android.providers.media.documents".Equals(uri.Authority);
        }

        //Whether the Uri authority is Google Photos.
        public static bool isGooglePhotosUri(Android.Net.Uri uri)
        {
            return "com.google.android.apps.photos.content".Equals(uri.Authority);
        }

        private int exifToDegrees(int exifOri)
        {
            if (exifOri == (int)Android.Media.Orientation.Rotate90)
            {
                return 90;
            }
            else if (exifOri == (int)Android.Media.Orientation.Rotate180)
            {
                return 180;
            }
            else if (exifOri == (int)Android.Media.Orientation.Rotate270)
            {
                return 270;
            }
            return 0;
        }
    }
}