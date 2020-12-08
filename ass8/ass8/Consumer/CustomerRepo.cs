using SQLite;
using System;
using System.Collections.Generic;

namespace ass8
{
    class CustomerRepo
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public CustomerRepo(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Customer>();
        }
        public void AddNewCustomer(string Name, string LastName, string Gender, string Tsize, string Tcolor, string Date, string Address)
        {
            int result = 0;
            try
            {
                if (string.IsNullOrEmpty(Name))
                    throw new Exception("Valid name required");
                result = conn.Insert(new Customer { Name = Name, LastName = LastName, Gender = Gender, Tsize = Tsize, TColor = Tcolor, Date = Date, Address = Address });

                StatusMessage = string.Format("{0} record(s) added [Name: {1}]", result, Name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", Name, ex.Message);
            }
        }

        public List<Customer> GetAllPeople()
        {
            try
            {
                return conn.Table<Customer>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return new List<Customer>();
        }

      
    }
}
