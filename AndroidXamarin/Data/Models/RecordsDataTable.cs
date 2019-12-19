using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidXamarin.Data.Models
{
    public class RecordsDataTable
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
            DataTable table = new DataTable("Records");
            table.Columns.Add(column);
            table.Columns.Add("Date & Time", typeof(DateTime));
            table.Columns.Add("Situation", typeof(String));
            table.Columns.Add("Emotion", typeof(String));
            //table.Columns.Add("Happy", typeof(Boolean));
            //table.Columns.Add("Sad", typeof(Boolean));
            //table.Columns.Add("Angry", typeof(Boolean));
            //table.Columns.Add("Confused", typeof(Boolean));
            //table.Columns.Add("Disgusted", typeof(Boolean));
            //table.Columns.Add("Suprised", typeof(Boolean));
            //table.Columns.Add("Calm", typeof(Boolean));
            //table.Columns.Add("Fear", typeof(Boolean));
            //table.Columns.Add("Unknown", typeof(Boolean));
            table.Columns.Add("Photo", typeof(Byte[]));
            table.Columns.Add("User", typeof(int));

            table.Rows.Add(null, "2019-10-11 9:14:34", "Hungry AF", "SAD", null, null);
            table.Rows.Add(null, "2019-12-11 4:42:12", "Sleeping", "HAPPY", null, null);
            table.Rows.Add(null, "2019-12-21 2:35:20", "Walking", "FEAR", null, null);
            /*
            HistoryItem hi1 = new HistoryItem()
            {
                id = 1,
                event_date = "2016 - 03 - 23",
                event_name = "Pretending to work",
                mood = "Confused",
                photo = "jim1"
            };
            list_source.Add(hi1);

            HistoryItem hi2 = new HistoryItem()
            {
                id = 1,
                event_date = "2017 - 08 - 14",
                event_name = "Working",
                mood = "Sad",
                photo = "jim2"
            };
            list_source.Add(hi2);

            HistoryItem hi3 = new HistoryItem()
            {
                id = 1,
                event_date = "2018 - 02 - 14",
                event_name = "Just got fired",
                mood = "Happy",
                photo = "jim3"
            };
            list_source.Add(hi3);
            */
            return table;
        }
    }
}