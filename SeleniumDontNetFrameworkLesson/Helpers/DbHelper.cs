using SeleniumDontNetFrameworkLesson.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDontNetFrameworkLesson.Helpers
{
    public static class DbHelper
    {
        //(localdb)\MSSQLLocalDB

        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True";
        private const string selectAllQuery = "SELECT * FROM Employees";

        public static void GetAll()
        {
            var employees = new List<Employees>();

            // Establish the connection
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Example query
                    const string query = "SELECT * FROM EmployeeInfo";

                    // Execute the query
                    using (var command = new SqlCommand(query, connection))
                    {
                        // Execute the reader
                        using (var reader = command.ExecuteReader())
                        {
                            // Check if the reader has rows
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var employee = new Employees();
                                    employee.Name = reader["Name"].ToString();
                                    employee.JobTitle = reader["JobTitle"].ToString();
                                    employee.Level = Convert.ToInt32(reader["Level"]);
                                    employees.Add(employee);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
