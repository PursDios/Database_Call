using System;
using System.Collections.Generic;
using System.Text;

namespace Database_Test
{
    class Controller
    {
        DatabaseController dbc;
        View v;
        public Controller()
        {
            dbc = new DatabaseController();
            v = new View();
        }

        public void displayCustomerDetails()
        {
            List<Customer> customers = dbc.GetCustomers();
            v.CustomerDetails(customers);
        }
    }
}