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

namespace AndroidXamarin.Data.Data
{
    public class Record
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string dateTime { get; set; }
        public string situation { get; set; }
        public string emotion { get; set; }
        public Byte[] Photo { get; set; }
        public String User { get; set; }
    }
}