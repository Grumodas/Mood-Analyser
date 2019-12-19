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
using Xamarin.Forms;

namespace AndroidXamarin.Data.Data
{
    public class RecordsDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;
        public RecordsDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();

            database.CreateTable<Record>();
        }
        public Record GetRecord()
        {
            if (database.Table<Record>().Count() == 0)
            {
                return null;
            }
            else
            {
                return database.Table<Record>().First();
            }
        }

        public int SaveRecord(Record record)
        {
            lock (locker)
            {
                if (record.Id != 0)
                {
                    database.Update(record);
                    return record.Id;
                }
                else
                {
                    return database.Insert(record);
                }
            }
        }

        public int DeleteRecord(int Id)
        {
            lock (locker)
            {
                return database.Delete<Record>(Id);
            }
        }
    }
}