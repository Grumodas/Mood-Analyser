using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataStorage.Models;

namespace DataStorage.Data
{/*
    public class UserDatabase
    {
        readonly SQLiteAsyncConnection database;

        public UserDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Users>().Wait();
        }

        public Task<List<Users>> GetItemsAsync()
        {
            return database.Table<Users>().ToListAsync();
        }

        public Task<Users> GetItemAsync(int id)
        {
            return database.Table<Users>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Users user)
        {
            if (user.Id != 0)
            {
                return database.UpdateAsync(user);
            }
            else
            {
                return database.InsertAsync(user);
            }
        }

        public Task<int> DeleteItemAsync(Users user)
        {
            return database.DeleteAsync(user);
        }
    }*/
}
