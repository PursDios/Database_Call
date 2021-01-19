using System;
using System.Collections.Generic;
using System.Text;

namespace Database_Test
{
    class DatabaseController
    {
        Database d = new Database();
        public List<Customer> GetCustomers()
        {
            var K = new SqlKata.Query();
            K.Select("*").FromRaw("customers");

            List<Customer> customers = d.SelectQuery(K);
            return customers;
        }
    }
}
