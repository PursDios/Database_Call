using System;
using System.Collections.Generic;
using System.Text;

namespace Database_Test
{
    class View
    {
        public bool CustomerDetails(List<Customer> customers)
        {
            foreach(Customer c in customers) {
                Console.WriteLine("Id: {0}", c.id);
                Console.WriteLine("Name: {0}", c.name);
                Console.WriteLine("Age: {0}", c.age);
                Console.WriteLine("");
            }

            return true;
        }
    }
}
