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
        List<HistoryItem> disp_list;
        TextView entry_count_text;
        int entry_count;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HistoryForm);

            //entry_count_text = FindViewById<TextView>(Resource.Id.entry_count);
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

            HistoryItem hi;

            IEnumerable<HistoryItem> happy_list_linq = from list_item in list_source
                                                       where list_item.mood == "Happy"
                                                       select list_item;
            List<HistoryItem> happy_list = new List<HistoryItem>();

            foreach (HistoryItem item in happy_list_linq)
            {
                happy_list.Add(item);
            }


            //IEnumerable<HistoryItem> sad_list_linq = from list_item in list_source
            //                                           where list_item.mood == "sad"
            //                                           select list_item;
            //List<HistoryItem> sad_list = new List<HistoryItem>();

            //foreach (HistoryItem item in sad_list_linq)
            //{
            //    sad_list.Add(item);
            //}


            //IEnumerable<HistoryItem> confused_list_linq = from list_item in list_source
            //                                           where list_item.mood == "confused"
            //                                           select list_item;
            //List<HistoryItem> confused_list = new List<HistoryItem>();

            //foreach (HistoryItem item in confused_list_linq)
            //{
            //    confused_list.Add(item);
            //}

            //String[] all_filters = filter.Split(",");
            //disp_list = new List<HistoryItem>();

            //if(filter.Contains("happy"))
            //{
            //    disp_list = happy_list;
            //}
            //if (filter.Contains("sad"))
            //{
            //    IEnumerable<HistoryItem> temp_disp_list = disp_list.Concat(happy_list);
            //    foreach (HistoryItem item in temp_disp_list)
            //    {
            //        disp_list.Add(item);
            //    }
            //}



            var adapter = new HistoryFormAdapter(this, happy_list);
            list_view.Adapter = adapter;
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                filter = data.GetStringExtra("filter");


                //list_source = simpleservice.getfilteredEntries(filter, full_history);
            }
        }
    }
}