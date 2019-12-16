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
    [Activity(Label = "CreateNewUserFormActivity")]
    public class CreateNewUserFormActivity : Activity
    {

        Button add_button;
        EditText username { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CreateNewUserForm);

            username = FindViewById<EditText>(Resource.Id.input_username);
            add_button = FindViewById<Button>(Resource.Id.confirm_input_username);

            add_button.Click += delegate
            {
                Intent myIntent = new Intent(this, typeof(LogInFormActivity));
                myIntent.PutExtra("name", username.Text);
                SetResult(Result.Ok, myIntent);
                Finish();
            };

            // Create your application here
        }
    }
}