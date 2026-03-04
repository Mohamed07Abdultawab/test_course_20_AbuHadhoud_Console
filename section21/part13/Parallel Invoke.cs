using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section21.part13
{
    public class Parallel_Invoke
    {
        public void Display()
        {
            Console.WriteLine("Invoke funcitons with parallel invok");
            Parallel.Invoke(Function1, Function2, Function3);

            //or 

            Parallel.Invoke(() =>
            {
                Console.WriteLine("content of function1");
                Task.Delay(1000).Wait();
                Console.WriteLine("function 1 is completed");
            }, () => { });
        }

        static void Function1()
        {
            Console.WriteLine("content of function1");
            Task.Delay(1000).Wait();
            Console.WriteLine("function 1 is completed");
        }
        static void Function2()
        {
            Console.WriteLine("content of function2");
            Task.Delay(1000).Wait();
            Console.WriteLine("function 2 is completed");
        }
        static void Function3()
        {
            Console.WriteLine("content of function3");
            Task.Delay(1000).Wait();
            Console.WriteLine("function 3 is completed");
        }

    }
}
