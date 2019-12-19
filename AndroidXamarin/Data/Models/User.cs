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
using SQLite;

namespace AndroidXamarin.Data.Models
{
    public class User
    {
        [PrimaryKey]
        public string name { get; set; }
        public Byte[] refPhoto { get; set; }
        //public Boolean hasRefPhoto { get; set; }
    }
}