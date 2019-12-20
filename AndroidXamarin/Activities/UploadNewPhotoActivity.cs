using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.Graphics;
using Android.Media;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidXamarin.Activities;
using Java.IO;
using Java.Text;
using Java.Util;
using System.Drawing;
using AWSLambdaClient;

namespace AndroidXamarin
{
    [Activity(Label = "UploadNewPhotoActivity")]
    public class UploadNewPhotoActivity : Activity
    {
        Button upload;
        Button confirm;
        ImageView image;
        EditText eventName;
        TextView waitMsg;
        Android.Graphics.Bitmap bm;
        string img_path;
        string emot;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_upload_new_photo);

            upload = FindViewById<Button>(Resource.Id.add_photo_upload_photo);
            confirm = FindViewById<Button>(Resource.Id.add_photo_confirm);
            image = FindViewById<ImageView>(Resource.Id.add_photo_image);
            eventName = FindViewById<EditText>(Resource.Id.add_photo_event_name);
            waitMsg = FindViewById<TextView>(Resource.Id.add_photo_wait);

            EmotDetector ed = new EmotDetector();
            String emotions;
            Emotion emos;
            Info info;


            upload.Click += (s, e) =>
            {
                 waitMsg.Visibility = ViewStates.Gone;
                 Intent imageIntent = new Intent();
                 imageIntent.SetType("image/*");
                 imageIntent.SetAction(Intent.ActionGetContent);
                 StartActivityForResult(Intent.CreateChooser(imageIntent, "Select photo"), 0);
            };
            /*
            confirm.Click += delegate
            {
                Toast toast = Toast.MakeText(Application.Context, "Confirmed", ToastLength.Short);
                toast.Show();
                Intent myIntent = new Intent(this, typeof(MainMenuFormActivity));
                HistoryFormActivity.list_source.Add(createHI(BitToByte(bm)));
                Finish();
            };
            */
            
            confirm.Click += async delegate {
                // layour object visibility managed
                confirm.Visibility = ViewStates.Gone;
                upload.Visibility = ViewStates.Invisible;
                waitMsg.Text = "Inspecting... Please Wait";
                waitMsg.Visibility = ViewStates.Visible;

                // not sure what's  happening
                emotions = "";
                emos = new Emotion();
                info = new Info();

                emotions = await ed.WhatEmot(img_path, System.IO.Path.GetFileName(img_path));
                //String result = emotions;
                emotions = emotions.Replace("\"", "");
                emos = new Emotion();
                int i = 0;
                string[] emotionArray = emotions.Split(',');
                
                if (emotionArray[0] == "")
                {
                    emos = Emotion.UNKNOWN;
                    emotions = "UNKNOWN";
                }
                else
                {
                    foreach (string emotion in emotionArray)
                    {
                        if (i == 0)
                        {
                            emos = (Emotion)Enum.Parse(typeof(Emotion), emotion);
                            i++;
                        }
                        else
                        {
                            emos |= (Emotion)Enum.Parse(typeof(Emotion), emotion);
                        }
                    }
                }
                //Not sure how your code worked here, so I just used a wooden option, sry
                emot = emotionArray[0];

                // According to recently collected data, creates HistoryItem and adds it to main list(list_source)
                CurrentUser.list_source.Add(createHI());
   
                upload.Visibility = ViewStates.Visible;
                waitMsg.Text = "You feel: " + emot;
                //Toast.MakeText(this, emotions, ToastLength.Short).Show();
                //AlertDialog.Builder alert = new AlertDialog.Builder(this);
                //alert.SetTitle("#feelz");
                //alert.SetMessage(result);
                //Dialog dialog = alert.Show();
                //info = new Info("TEST EVENT NAME", emos);
                //Byte[] image = System.IO.File.ReadAllBytes(img_path);
            };



        }

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
                int rot_deg  = exifToDegrees(rot);
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

        private byte[] BitToByte(Android.Graphics.Bitmap bitm)
        {
            byte[] bitmapData;
            using (var stream = new MemoryStream())
            {
                bm.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 0, stream);
                bitmapData = stream.ToArray();
            }

            return bitmapData;
        }

        private HistoryItem createHI()
        {
            byte[] ba = BitToByte(bm);
            string date = DateTime.Now.ToString();

            HistoryItem hi = new HistoryItem() {
                id = 1,
                event_date = date,
                event_name = eventName.Text,
                mood = emot,
                photo = ba,
                user = CurrentUser.name

            };
            return hi;
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
            } else if (exifOri == (int)Android.Media.Orientation.Rotate270)
            {
                return 270;
            }
            return 0;
        }
    }


} 

