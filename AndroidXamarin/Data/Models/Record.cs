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

        //public Boolean happy { get; set; }
        //public Boolean sad { get; set; }
        //public Boolean angry { get; set; }
        //public Boolean confused { get; set; }
        //public Boolean disgusted { get; set; }
        //public Boolean suprised { get; set; }
        //public Boolean calm { get; set; }
        //public Boolean fear { get; set; }
        //public Boolean unknown { get; set; }
        public Byte[] Photo { get; set; }
        public String User { get; set; }
    }
}