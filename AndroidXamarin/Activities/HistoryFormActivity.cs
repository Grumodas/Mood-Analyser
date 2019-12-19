﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidXamarin.Activities;
using AndroidXamarin.Data.Data;
using AndroidXamarin.Data.Models;
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
        public static List<HistoryItem> list_source;
        public static List<HistoryItem> list_users;
        public List<HistoryItem> list_filtered { get; set; }
        HistoryFormAdapter adapter;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HistoryForm);

            //entry_count_text = FindViewById<TextView>(Resource.Id.entry_count);
            filter_button = FindViewById<Button>(Resource.Id.history_filter);
            list_view = FindViewById<ListView>(Resource.Id.history_list);
            list_source = new List<HistoryItem>();
            list_users = new List<HistoryItem>();
            list_filtered  = new List<HistoryItem>();
            adapter = new HistoryFormAdapter(this, list_filtered);
            filter = "None";

            filter_button.Click += (s, e) =>
            {
                Intent filter_activity = new Intent(this, typeof(FilterFormActivity));
                filter_activity.PutExtra("curr_filter", filter);
                StartActivityForResult(filter_activity, 0);
            };


            //mock data
            //______________________ HISTORY LIST POLULATION __________
            DataTable data = RecordsDataTable.GetTable();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Record record = new Record();
                record.Id = Convert.ToInt32(data.Rows[i]["Id"]);
                record.dateTime = data.Rows[i]["Date & Time"].ToString();
                record.situation = data.Rows[i]["Situation"].ToString();
                record.emotion = data.Rows[i]["Emotion"].ToString();


                HistoryItem hi = new HistoryItem();
                hi.event_date = record.dateTime;
                hi.event_name = record.situation;
                hi.mood = record.emotion;
                //Turi konvertuoti is masyvo i photo ar kazkoki kita hunjia
                hi.photo = null;
                list_source.Add(hi);
                //list_filtered.Add(hi);
            }
            /*
            HistoryItem hi1 = new HistoryItem()
            {
                id = 1,
                event_date = "2016 - 03 - 23",
                event_name = "Pranking",
                mood = "Confused",
                photo = "jim1",
                user = "agent 0"
            };
            list_source.Add(hi1);
            //list_filtered.Add(hi1);

            HistoryItem hi2 = new HistoryItem()
            {
                id = 1,
                event_date = "2017 - 08 - 14",
                event_name = "Working",
                mood = "Sad",
                photo = "jim2",
                user =  "agent 1"
            };
            list_source.Add(hi2);
            //list_filtered.Add(hi2);

            HistoryItem hi3 = new HistoryItem()
            {
                id = 1,
                event_date = "2018 - 02 - 14",
                event_name = "Just got fired",
                mood = "Happy",
                photo = "jim3",
                user = "agent 0"
            };
            list_source.Add(hi3);
            //list_filtered.Add(hi3);

            HistoryItem hi4 = new HistoryItem()
            {
                id = 1,
                event_date = "2018 - 03 - 23",
                event_name = "Pretending to work",
                mood = "Sad",
                photo = "jim1",
                user = "agent 0"
            };
            list_source.Add(hi4);

            //list_filtered.Add(hi4);
            #endregion
            */

            foreach (HistoryItem hi in list_source)
            {
                Toast toast = Toast.MakeText(Application.Context, "Now: " + hi.mood, ToastLength.Short);
                toast.Show();
                if (hi.user == CurrentUser.name)
                {
                    list_users.Add(hi);
                    list_filtered.Add(hi);
                }
            }

            list_view.Adapter = adapter;

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                filter = data.GetStringExtra("filter");

                if (filter != "none") {
                    list_filtered.Clear();
                    foreach (HistoryItem hi in list_users)
                    {
                        if (hi.mood == filter)
                        {
                            list_filtered.Add(hi);
                        }
                    }
                }

                list_view.Adapter = adapter;
            }
        }
    }
}