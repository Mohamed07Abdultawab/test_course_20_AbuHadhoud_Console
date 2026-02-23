using Microsoft.Win32;
using System;

namespace test_course_20_AbuHadhoud_Console.section14.part3
{
    public class Reading_from_Registry
    {
        public void Dispay()
        {
            //identify where you will writing
            string KeyPath = @"HKEY_CURRENT_USER\Software\AVAST Software\Browser\Extensions";

            string valueName = "testValueName";

            //using try catck to handel exception
            try
            {
                //write the value to the registry
                string value = Registry.GetValue(KeyPath, valueName, null) as string;

                if (value != null)
                    Console.WriteLine($"the value of {valueName} is: {value}");
                else
                    Console.WriteLine($"the value of {valueName} is not found in Registry");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurrd: {ex.Message}");
            }
        }
    }
}
