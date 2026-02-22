using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section13.part2
{

    public class Utility
    {
        public static T Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
            return temp;
        }
    }
    public class Generic_Methods
    {
        public void Display()
        {
            int a =5, b =6;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            Utility.Swap( ref a, ref b );
            Console.WriteLine($"After swap: a = {a}, b = {b}");
            Console.WriteLine();

            // Usage with strings
            string x = "Hello", y = "World";
            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            Utility.Swap(ref x, ref y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");
        }
    }
}
