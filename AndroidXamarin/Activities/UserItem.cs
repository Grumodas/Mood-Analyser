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
    public class UserItem
    {
        public string name { get; set; }
        public Byte[] refPhoto { get; set; }
        public bool has_ref_photo { get; set; }
        public int id { get; set; }
    }
}