using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace DataStorage.Models
{
    class RecordsDataTable
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
            table.Columns.Add("Date & Time", typeof(DateTime));
            table.Columns.Add("Situation", typeof(String));
            table.Columns.Add("Happy", typeof(Boolean));
            table.Columns.Add("Sad", typeof(Boolean));
            table.Columns.Add("Angry", typeof(Boolean));
            table.Columns.Add("Confused", typeof(Boolean));
            table.Columns.Add("Disgusted", typeof(Boolean));
            table.Columns.Add("Suprised", typeof(Boolean));
            table.Columns.Add("Calm", typeof(Boolean));
            table.Columns.Add("Fear", typeof(Boolean));
            table.Columns.Add("Unknown", typeof(Boolean));
            table.Columns.Add("Photo", typeof(Byte[]));
            table.Columns.Add("User", typeof(int));

            return table;
        }
    }
}