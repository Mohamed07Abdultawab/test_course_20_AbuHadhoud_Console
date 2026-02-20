using System;
using System.Data.SqlClient;
using System.Data.SqlTypes; // تأكد إنها مكتوبة صح فوق

namespace test_course_20_AbuHadhoud_Console.section6.part4
{
/*
    public class ResourceManagement
    {
        public static void connectionDatabase()
        {
            string connectionString = "your_connection_string_here";

            try
            {
                // جرب تكتب SqlConnection مباشرة بدون المسار الطويل
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select firstName, lastName from Employee";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string firstName = reader.GetString(0);
                                string lastName = reader.GetString(1);
                                Console.WriteLine($"Employee: {firstName} {lastName}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
*/

}