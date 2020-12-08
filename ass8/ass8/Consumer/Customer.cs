using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ass8
{
    class Customer
    { 
       [SQLite.PrimaryKey, AutoIncrement]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Tsize { get; set; }
        public string TColor { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }




    }
}
