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
using SkiaSharp;
using SkiaSharp.Views.Android;
using Android.Support.V7.App;

namespace AndroidXamarin.Activities
{
    [Activity(Label = "MosaicFormActivity")]
    public class MosaicFormActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MosaicForm);

            SKCanvasView cv = FindViewById<SKCanvasView>(Resource.Id.mosaic_canvas);
            cv.PaintSurface += OnPaintSurface;

            // Create your application here
        }

        private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            //SharedPage.OnPainting(sender, e);

        }
    }
}