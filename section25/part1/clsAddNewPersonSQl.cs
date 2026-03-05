using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace test_course_20_AbuHadhoud_Console.section25.part1
{
    public class clsAddNewPersonSQl
    {
        public void Display()
        {
            string connectionString = "Server=.;Database=Course20_Test;User Id=sa;Password=123456;TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);
                using SqlCommand command = new SqlCommand("SP_AddNewPerson", connection);
                command.CommandType = CommandType.StoredProcedure;


                // Add parameters
                command.Parameters.AddWithValue("@FirstName", "John");
                command.Parameters.AddWithValue("@LastName", "Doe");
                command.Parameters.AddWithValue("@Email", "john.doe@example.com");
                SqlParameter outputIdParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);


                // Execute
                connection.Open();
                command.ExecuteNonQuery();


                // Retrieve the ID of the new person
                int newPersonID = (int)command.Parameters["@NewPersonID"].Value;
                Console.WriteLine($"New Person ID: {newPersonID}");

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                connection.Close();
        }
    }
}
