using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorage.Models
{
    public class Records
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public string situation { get; set; }
        public Boolean happy { get; set; }
        public Boolean sad { get; set; }
        public Boolean angry { get; set; }
        public Boolean confused { get; set; }
        public Boolean disgusted { get; set; }
        public Boolean suprised { get; set; }
        public Boolean calm { get; set; }
        public Boolean fear { get; set; }
        public Boolean unknown { get; set; }
        public Byte[] Photo { get; set; }
        public int User { get; set; }
    }
}