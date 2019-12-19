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

            DataColumn column = new DataColumn("Id");
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 1;
            column.AutoIncrementStep = 1;
            column.ReadOnly = true;

            // Add the column to a new DataTable.
            // Create table
            DataTable table = new DataTable("Subject");
            table.Columns.Add(column);
            table.Columns.Add("Name", typeof(String));

            table.Rows.Add(null, "Arnas");
            table.Rows.Add(null, "Rimantas");
            table.Rows.Add(null, "Kestutis");

            return table;
        }
    }
}