using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section21.part11
{
    public class Parallel_For
    {
        //implemntation in same time 
        public void Display()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");

                Task.Delay(1000).Wait();
            });

            Console.WriteLine("End of program.");
        }
    }
}
