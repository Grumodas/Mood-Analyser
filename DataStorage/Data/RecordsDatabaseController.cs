using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using DataStorage.Models;

namespace DataStorage.Data
{
    class RecordsDatabaseController
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
            if(database.Table<Record>().Count() == 0)
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
                if(record.Id != 0)
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
