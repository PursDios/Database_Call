using System;
using System.Collections.Generic;
using System.Text;
using SqlKata;
using SqlKata.Compilers;
using MySql.Data.MySqlClient;

namespace Database_Test
{

    class Database
    {
        //realistically this will be obtained somewhere else and login details will be substitued based on environment.
        string local = "server=localhost;user=root;database=awesomedb;password=";
        MySqlConnection connection;
        SqlServerCompiler sqlCompiler;

        public List<Customer> SelectQuery(Query kataQuery)
        {
            List<Customer> customers = new List<Customer>();

            try {
                connection = new MySqlConnection(local);
                sqlCompiler = new SqlServerCompiler();
                MySqlDataReader sdr;
                SqlResult query = sqlCompiler.Compile(kataQuery);

                using (MySqlCommand cmd = new MySqlCommand(query.Sql, connection)) {
                    connection.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read()) {
                        Customer c = new Customer();
                        c.id = (Int32)sdr[0];
                        c.name = (string)sdr[1];
                        c.age = (Int32)sdr[2];
                        customers.Add(c);
                    }
                    connection.Close();

                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return customers;
        }
    }
}

