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

namespace AndroidXamarin.Activities
{
    [Activity(Label = "LogInFormActivity", MainLauncher = true)]
    public class LogInFormActivity : Activity
    {

        ListView list_view;
        List<UserItem> list_source;
        Button confirm;
        Button add_user;
        EditText input;
        Boolean user_exsists;
        // The username of the CURRENT USER
        public static string username { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LogInForm);

            list_view = FindViewById<ListView>(Resource.Id.user_list_view);
            list_source = new List<UserItem>();
            input = FindViewById<EditText>(Resource.Id.input_text);
            confirm = FindViewById<Button>(Resource.Id.confirm_username);
            add_user = FindViewById<Button>(Resource.Id.add_user);

            confirm.Click += (s, e) =>
            {
                user_exsists = false;
                username = input.Text;

                foreach (UserItem user in list_source)
                {
                    if (username == user.name)
                    {
                        user_exsists = true;
                        break;
                    }
                }

                if (user_exsists)
                {
                    Intent main_menu_activity = new Intent(this, typeof(MainMenuFormActivity));
                    StartActivity(main_menu_activity);
                } else
                {
                    input.Text = "NOT FOUND";
                }
            };

            add_user.Click += (s, e) =>
            {
                Intent create_user_activity = new Intent(this, typeof(CreateNewUserFormActivity));
                StartActivityForResult(create_user_activity, 0);
            };

            UserItem user1 = new UserItem()
            {
                name = "Skywalker"
            };
            list_source.Add(user1);

            UserItem user2 = new UserItem()
            {
                name = "Bond"
            };
            list_source.Add(user2);

            var adapter = new SelectUserFormAdapter(this, list_source);
            list_view.Adapter = adapter;

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                string username = data.GetStringExtra("name");

                UserItem user = new UserItem()
                {
                    name = username
                };
                list_source.Add(user);


                //list_source = simpleservice.getfilteredEntries(filter, full_history);
            }
        }


    }
}