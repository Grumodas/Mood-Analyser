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

        TextView user_taken;
        EditText input;
        Button add_button;
        Boolean user_exsists;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CreateNewUserForm);

            user_taken = FindViewById<TextView>(Resource.Id.user_taken_message);
            input = FindViewById<EditText>(Resource.Id.create_user_input);
            add_button = FindViewById<Button>(Resource.Id.create_user_confirm);

            user_taken.Text = "";


            add_button.Click += delegate
            {
                user_exsists = false;

                foreach (UserItem user in LogInFormActivity.list_source)
                {
                    if (input.Text == user.name)
                    {
                        user_exsists = true;
                        break;
                    }
                }

                if (user_exsists)
                {
                    user_taken.Text = "USERNAME ALREADY TAKEN";
                    
                }
                else
                {
                    Intent myIntent = new Intent(this, typeof(LogInFormActivity));
                    myIntent.PutExtra("name", input.Text);
                    SetResult(Result.Ok, myIntent);
                    Finish();
                }
            };

            // Create your application here
        }
    }
}