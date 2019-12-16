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
    [Activity(Label = "LogInFormActivity")]
    public class LogInFormActivity : Activity
    {

        ListView list_view;
        List<UserItem> list_source;
        EditText input { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LogInForm);

            list_view = FindViewById<ListView>(Resource.Id.user_list_view);
            list_source = new List<UserItem>();
            input = FindViewById<EditText>(Resource.Id.input_text);

            UserItem user = new UserItem()
            {
                name = "Skywalker"
            };
            list_source.Add(user);

            UserItem user2 = new UserItem()
            {
                name = "Bond"
            };
            list_source.Add(user2);

            var adapter = new SelectUserFormAdapter(this, list_source);
            list_view.Adapter = adapter;

            // Create your application here

            String push = "pushhh";
        }
    }
}