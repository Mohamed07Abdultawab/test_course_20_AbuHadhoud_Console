using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section10.part1
{
    public class TypeClass
    {
        public void method()
        {
            Type mytype = typeof(string);
            Console.WriteLine("Type Information:");
            Console.WriteLine($"Name: {mytype.Name}");
            Console.WriteLine($"Full Name: {mytype.FullName}");
            Console.WriteLine($"is Class: {mytype.IsClass }");
        }
    }
}
 