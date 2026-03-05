using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace test_course_20_AbuHadhoud_Console.section25.part2
{
    public  class clsCheckPersonExist
    {
        public void Display()
        {
            /*
             CREATE PROCEDURE SP_CheckPersonExists
                @PersonID INT
            AS
            BEGIN
                IF EXISTS(SELECT * FROM People WHERE PersonID = @PersonID)
                    RETURN 1;  -- Person exists
                ELSE
                    RETURN 0;  -- Person does not exist
            END

             */

            CheckPersonExists(1);
        }

        public static void CheckPersonExists(int PersonID)
        {
            try
            {
                string connectionString = "Server=.;Database=Course20_Test;User Id=sa;Password=123456;TrustServerCertificate=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckPersonExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnParameter);
                        command.ExecuteNonQuery();

                        bool personExists = (int)returnParameter.Value == 1;

                        Console.WriteLine($" Person Exist   {personExists}");

                        connection.Close();

                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($" Person doesn't Exist   {ex.Message}");
            }

        }
    }
}
