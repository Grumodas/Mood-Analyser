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

namespace AndroidXamarin.Resources
{
    public class ViewHolder : Java.Lang.Object
    {
        public TextView dateText { get; set; }
        public TextView eventText { get; set; }
        public TextView moodText { get; set; }
        public ImageView photoBox { get; set; }
    }
    public class HistoryFormAdapter : BaseAdapter
    {
        private Activity activity;
        private List<HistoryItem> history_list;

        public HistoryFormAdapter(Activity activity, List<HistoryItem> history_list)
        {
            this.activity = activity;
            this.history_list = history_list;
        }

        public override int Count
        {
            get
            {
                return history_list.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return history_list[position].id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.HistoryItemLayout, parent, false);

            var dateText = view.FindViewById<TextView>(Resource.Id.history_item_date);
            var eventText = view.FindViewById<TextView>(Resource.Id.history_item_event);
            var moodText = view.FindViewById<TextView>(Resource.Id.history_item_mood);
            var photoBox = view.FindViewById<ImageView>(Resource.Id.history_item_photo);
            
            dateText.Text = history_list[position].event_date;
            eventText.Text = history_list[position].event_name;
            moodText.Text = history_list[position].mood;

            int imageId = (int)typeof(Resource.Drawable).GetField(history_list[position].photo).GetValue(null);
            photoBox.SetImageResource(imageId);
            //int someId = Resources

            return view;
        }
    }
}