using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace DataStorage.Models
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

            return table;
        }
    }
}