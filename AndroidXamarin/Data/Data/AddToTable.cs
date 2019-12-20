using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidXamarin.Data.Data
{
    class AddToTable
    {
        static void addRecord (DataTable table, String situation, String emotion, Byte[] img, String user)
        {

            table.Rows.Add(null, DateTime.Now.ToString(), situation, emotion, img, user);
        }

        static void addUser (DataTable table, String name, Byte[] img, int hasRefPhoto)
        {

            table.Rows.Add(name, img, hasRefPhoto);
        }
    }
}