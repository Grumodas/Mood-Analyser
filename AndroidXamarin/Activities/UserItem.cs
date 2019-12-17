﻿using System;
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
        public int id { get; set; }
        public string name { get; set; }
        public bool has_ref_photo { get; set; }
    }
}