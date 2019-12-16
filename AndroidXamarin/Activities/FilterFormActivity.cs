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
        RadioButton radio_happy, radio_sad, radio_surprised, radio_calm,
            radio_confused, radio_angry, radio_disgusted, radio_scared, radio_none;
        string filter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            radio_happy = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_sad = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_surprised = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_calm = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_confused = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_angry = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_disgusted = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_scared = FindViewById<RadioButton>(Resource.Id.radio_happy);
            radio_none = FindViewById<RadioButton>(Resource.Id.radio_happy);


            filter = Intent.GetStringExtra("curr_filter") ?? string.Empty;
            //setRadioButton();

            SetContentView(Resource.Layout.FilterFrom);

            confirm_button = FindViewById<Button>(Resource.Id.confirm_button);
            radio_group = FindViewById<RadioGroup>(Resource.Id.radio_group);

            confirm_button.Click += delegate
            {
                RadioButton radio_selected = FindViewById<RadioButton>(radio_group.CheckedRadioButtonId);

                string filter_name = radio_selected.Text;

                Intent myIntent = new Intent(this, typeof(HistoryFormActivity));
                myIntent.PutExtra("filter", filter_name);
                SetResult(Result.Ok, myIntent);
                Finish();
            };

        }

        private void setRadioButton()
        {
            
            switch (filter)
            {
                case "Happy":
                    radio_happy.Checked = true;
                break;

                case "Sad":
                    radio_sad.Checked = true;
                break;

                case "Surprised":
                    radio_surprised.Checked = true;
                break;

                case "Calm":
                    radio_calm.Checked = true;
                break;

                case "Confused":
                    radio_confused.Checked = true;
                break;

                case "Angry":
                    radio_angry.Checked = true;
                break;

                case "Disgusted":
                    radio_disgusted.Checked = true;
                break;

                case "Scared":
                    radio_scared.Checked = true;
                break;
                
            }
        }
    }
}
