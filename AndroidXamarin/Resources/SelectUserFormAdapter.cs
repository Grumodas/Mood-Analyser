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

namespace AndroidXamarin.Resources
{
    public class USerViewHolder : Java.Lang.Object
    {
        public TextView nameText { get; set; }
    }
    class SelectUserFormAdapter : BaseAdapter
    {
        private Activity activity;
        private List<UserItem> user_list;


        public SelectUserFormAdapter(Activity activity, List<UserItem> user_list)
        {
            this.activity = activity;
            this.user_list = user_list;
        }

        public override int Count
        {
            get
            {
                return user_list.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return user_list[position].id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.UserItemLayout, parent, false);

            var nameText = view.FindViewById<TextView>(Resource.Id.text);

            nameText.Text = user_list[position].name;

            return view;
        }
    }
}