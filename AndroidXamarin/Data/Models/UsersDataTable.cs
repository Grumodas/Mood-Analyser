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
using System.Data;

namespace AndroidXamarin.Data.Models
{
    class UsersDataTable
    {
        public static DataTable GetTable()
        {
            DataTable table = new DataTable("Users");

            table.Columns.Add("name", typeof(String));
            table.Columns.Add("refPhoto", typeof(Byte[]));
            //table.Columns.Add("hasRefPhoto", typeof(Boolean));

            table.Rows.Add("Arnas", null);
            table.Rows.Add("Rimantas", null);
            table.Rows.Add("Kestutis", null);

            return table;
        }
    }
}