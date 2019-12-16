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
    // comment line below to unset it as the launch activity
    [Activity(Label = "MainMenuFormActivity", MainLauncher = true)]
    class MainMenuFormActivity : Activity
    {
        Button add_button;
        Button history_button;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate (bundle);
            SetContentView (Resource.Layout.MainMenuForm);

            add_button = FindViewById<Button>(Resource.Id.add_new_button);
            history_button = FindViewById<Button>(Resource.Id.history_button);

            add_button.Click += (s, e) =>
            {
                //Insert activity label and uncomment lines below
                //Intent add_activity = new Intent(this, typeof(<<ACTIVITY LABEL>>));
                //StartActivity(add_activity);
            };

            history_button.Click += (s, e) =>
            {
                Intent history_activity = new Intent(this, typeof(HistoryFormActivity));
                StartActivity(history_activity);
            };

        }
    }
}