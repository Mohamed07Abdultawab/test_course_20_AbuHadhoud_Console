using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section9.part4
{
    public class Obsolete_Attribute
    {
        [Obsolete("This method is marked as obsolete, use method 2")]
        public void method1()
        {
            Console.WriteLine("the method is obsolete");
        }

        public void method2()
        {
            Console.WriteLine("this is recommended methoed to use.");
        }
    }
}
