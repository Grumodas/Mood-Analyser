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

namespace AndroidXamarin.Activities
{
    [Activity(Label = "FilterFormActivity")]
    public class FilterFormActivity : Activity
    {
        Button confirm_button;
        RadioGroup radio_group;
        RadioButton
            radio_angry,
            radio_calm,
            radio_confused,
            radio_disgusted,
            radio_happy, 
            radio_sad, 
            radio_scared,
            radio_surprised,
            radio_none;
        string curr_filter;
        List<string> filts;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.FilterFrom);

            radio_angry = FindViewById<RadioButton>(Resource.Id.filter_angry);
            radio_calm = FindViewById<RadioButton>(Resource.Id.filter_calm);
            radio_confused = FindViewById<RadioButton>(Resource.Id.filter_confused);
            radio_disgusted = FindViewById<RadioButton>(Resource.Id.filter_disgusted);
            radio_happy = FindViewById<RadioButton>(Resource.Id.filter_happy);
            radio_sad = FindViewById<RadioButton>(Resource.Id.filter_sad);
            radio_scared = FindViewById<RadioButton>(Resource.Id.filter_scared);
            radio_surprised = FindViewById<RadioButton>(Resource.Id.filter_surprised);
            radio_none = FindViewById<RadioButton>(Resource.Id.filter_none);

            confirm_button = FindViewById<Button>(Resource.Id.filter_confirm);

            curr_filter = Intent.GetStringExtra("curr_filter") ?? string.Empty;

            
 
            confirm_button.Click += delegate
            {
                Intent myIntent = new Intent(this, typeof(HistoryFormActivity));
                myIntent.PutExtra("filter", "Happy");
                SetResult(Result.Ok, myIntent);
                Finish();
            };
        }
    }
}
