using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataStorage.Models;

namespace DataStorage.Data
{
    public class SubjectDatabase
    {
        readonly SQLiteAsyncConnection database;

        public SubjectDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Records>().Wait();
        }

        public Task<List<Records>> GetItemsAsync()
        {
            return database.Table<Records>().ToListAsync();
        }

        public Task<Records> GetItemAsync(int id)
        {
            return database.Table<Records>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Records record)
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

        public Task<int> DeleteItemAsync(Records record)
        {
            return database.DeleteAsync(record);
        }
    }
}
