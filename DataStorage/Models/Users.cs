using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorage.Models
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
    }
}
