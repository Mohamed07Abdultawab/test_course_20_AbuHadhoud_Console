using System;
using Microsoft.Win32;

namespace test_course_20_AbuHadhoud_Console.section14.part4
{
    public class Permission_to_Write_to_Registry
    {
        //way1 to run vs code as administrator

        //way2
        public void Dispay()
        {
            //identify where you will writing
            string KeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftwar";

            string valueName = "testValueName";
            string valueData = "testValueData";

            //using try catck to handel exception
            try
            {
                //write the value to the registry
                Registry.SetValue(KeyPath, valueName, valueData, RegistryValueKind.String);

                Console.WriteLine($"Value {valueName} successfully written to the Registry.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurrd: {ex.Message}");
            }
        }
    }
}
