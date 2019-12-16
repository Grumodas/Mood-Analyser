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
using AndroidXamarin.Activities;
using AndroidXamarin.Resources;

namespace AndroidXamarin
{
    // comment line below to unset it as the launch activity
    [Activity(Label = "HistoryFormActivity")]
    class HistoryFormActivity : Activity
    {
        Button filter_button;
        string filter;
        ListView list_view;
        List<HistoryItem> list_source;
        List<HistoryItem> full_history;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HistoryForm);
            
            filter_button = FindViewById<Button>(Resource.Id.filter_button);
            filter = "None";

            filter_button.Click += (s, e) =>
            {
                Intent filter_activity = new Intent(this, typeof(FilterFormActivity));
                filter_activity.PutExtra("curr_filter", filter);
                StartActivityForResult(filter_activity, 0);
            };

            list_view = FindViewById<ListView>(Resource.Id.listView1);
            list_source = new List<HistoryItem>();

            //mock data
                HistoryItem hi1 = new HistoryItem()
                {
                    id = 1,
                    event_date = "2016 - 03 - 23",
                    event_name = "Pretending to work",
                    mood = "Confused",
                    photo = "jim1"
                };
                list_source.Add(hi1);

                HistoryItem hi2 = new HistoryItem()
                {
                    id = 1,
                    event_date = "2017 - 08 - 14",
                    event_name = "Working",
                    mood = "Sad",
                    photo = "jim2"
                };
                list_source.Add(hi2);

                HistoryItem hi3 = new HistoryItem()
                {
                    id = 1,
                    event_date = "2018 - 02 - 14",
                    event_name = "Just got fired",
                    mood = "Happy",
                    photo = "jim3"
                };
                list_source.Add(hi3);


            var adapter = new HistoryFormAdapter(this, list_source);
            list_view.Adapter = adapter;
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                filter= data.GetStringExtra("filter");


                //list_source = simpleservice.getfilteredEntries(filter, full_history);
            }
        }
    }
}