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

namespace AndroidXamarin
{
    public class HistoryItem
    {
        public int id { get; set; }
        public string event_date { get; set; }
        public string event_name { get; set; }
        public string mood { get; set; }
        //proabaly not string
        public string photo { get; set; }
    }
}