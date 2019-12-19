using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using AndroidXamarin.Data.Models;

namespace AndroidXamarin.Data.Data
{
    public class SubjectDatabase
    {
        readonly SQLiteAsyncConnection database;

        public SubjectDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Record>().Wait();
        }

        public Task<List<Record>> GetItemsAsync()
        {
            return database.Table<Record>().ToListAsync();
        }

        public Task<Record> GetItemAsync(int id)
        {
            return database.Table<Record>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Record record)
        {
            if (record.Id != 0)
            {
                return database.UpdateAsync(record);
            }
            else
            {
                return database.InsertAsync(record);
            }
        }

        public Task<int> DeleteItemAsync(Record record)
        {
            return database.DeleteAsync(record);
        }
    }
}