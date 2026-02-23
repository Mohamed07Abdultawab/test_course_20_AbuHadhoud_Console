using Microsoft.Win32;//must use
using System;


namespace test_course_20_AbuHadhoud_Console.section14.part2
{
    public class Writing_to_Registry
    {
        public void Dispay()
        {
            //identify where you will writing
            string KeyPath = @"HKEY_CURRENT_USER\Software\AVAST Software\Browser\Extensions";

            string valueName = "testValueName";
            string valueData = "testValueData";

            //using try catck to handel exception
            try
            {
                //write the value to the registry
                Registry.SetValue(KeyPath, valueName, valueData, RegistryValueKind.String);

                Console.WriteLine($"Value {valueName} successfully written to the Registry.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurrd: {ex.Message}");
            }
        }
    }
}
