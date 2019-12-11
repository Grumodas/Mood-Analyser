using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorage.Models
{
    class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
    }
}
