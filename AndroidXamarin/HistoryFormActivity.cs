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
using AndroidXamarin.Resources;

namespace AndroidXamarin
{
    // comment line below to unset it as the launch activity
    [Activity(Label = "HistoryFormActivity", MainLauncher = true)]
    class HistoryFormActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.HistoryForm);

            var listData = FindViewById<ListView>(Resource.Id.listView1);

            List<HistoryItem> listSource = new List<HistoryItem>();

            HistoryItem hi1 = new HistoryItem()
            {
                id = 1,
                event_date = "2016 - 03 - 23",
                event_name = "Pretending to work",
                mood = "Confused",
                photo = "jim1"
            };
            listSource.Add(hi1);

            HistoryItem hi2 = new HistoryItem()
            {
                id = 1,
                event_date = "2017 - 08 - 14",
                event_name = "Working",
                mood = "Sad",
                photo = "jim2"
            };
            listSource.Add(hi2);

            HistoryItem hi3 = new HistoryItem()
            {
                id = 1,
                event_date = "2018 - 02 - 14",
                event_name = "Just got fired",
                mood = "Happy",
                photo = "jim3"
            };
            listSource.Add(hi3);


            var adapter = new HistoryFormAdapter(this, listSource);
            listData.Adapter = adapter;

        }
    }
}