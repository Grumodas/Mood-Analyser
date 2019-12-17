﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidXamarin.Resources;

//nuGet packages:

//downloaded:
//For splashScreen:
//Xamarin.Android.Support.v4
//Xamarin.Android.Support.v7.AppCompat 

//not downloaded:
//To make gridview work well on older devices, install nuGet package:
//xamarin.android.suppord.v7.gridLayout

namespace AndroidXamarin.Activities
{
    [Activity(Label = "LogInFormActivity"/*, MainLauncher = true*/)]
    public class LogInFormActivity : Activity
    {

        ListView list_view;
        SelectUserFormAdapter adapter;
        public static ObservableCollection<UserItem> list_source { get; set; }
        Button add_user;
        string username;
        string selected_user;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LogInForm);
            //ListView Id bugged
            list_view = FindViewById<ListView>(Resource.Id.login_list);
            add_user = FindViewById<Button>(Resource.Id.login_add);
            list_source = new ObservableCollection<UserItem>();
            adapter = new SelectUserFormAdapter(this, list_source);

            #region
            /*
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
            */
            #endregion

            add_user.Click += (s, e) =>
            {
                Intent create_user_activity = new Intent(this, typeof(CreateNewUserFormActivity));
                StartActivityForResult(create_user_activity, 0);
            };

            // adding mock data
            for (int i = 0; i < 12; i++)
            {
                UserItem mock_user = new UserItem()
                {
                    name = "agent " + i,
                    has_ref_photo = false
                };

                list_source.Add(mock_user);
            }

            
            list_view.Adapter = adapter;
            list_view.ItemClick += userListOnItemClick;
        }

        private void userListOnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            CurrentUser.name = list_source[e.Position].name;
            CurrentUser.has_ref_photo = list_source[e.Position].has_ref_photo;


            //<<Check if user has ref photogo to main menu, if not - add ref screen>>


            Intent main_menu_activity = new Intent(this, typeof(MainMenuFormActivity));
            StartActivity(main_menu_activity);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                UserItem new_user = new UserItem()
                {
                    name = username = data.GetStringExtra("name"),
                    has_ref_photo = false
                };

                list_source.Add(new_user);

                //adapter = new SelectUserFormAdapter(this, list_source);
                list_view.Adapter = adapter;
                list_view.ItemClick += userListOnItemClick;
            }
        }
    }
}