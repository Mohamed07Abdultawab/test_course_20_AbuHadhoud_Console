using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section7.part2
{
    public static class Nullable_Datatypes_Example_2
    {
        //Nullable<int> & int? are the same thing, int? is just a shorthand syntax for Nullable<int>
        public static void Procedure1(string Name, Nullable<int> Age)
        {
            Console.WriteLine("\nName is: " + Name);

            if(Age.HasValue)
            {
                Console.WriteLine("Age is: " + Age.Value);
            }
            else
            {
                Console.WriteLine("Age is not provided.");
            }
        }

        public static void Procedure2(string Name, int? Age)
        {
            Console.WriteLine("\nName is: " + Name);

            Console.WriteLine("Age is: " + Age?.ToString() ?? "not provided");//will print Age is: -> because + in console will convert null to empty string, so we need to use null-coalescing operator to provide a default value when Age is null
            Console.WriteLine($"Age is: {Age?.ToString()?? "not provided"}");//using string interpolation to print the value of Age, and using null-coalescing operator to provide a default value when Age is null
        }
    }
}
