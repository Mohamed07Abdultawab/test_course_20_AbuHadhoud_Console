using System;
using System.Reflection.Metadata;
using System.Threading;

namespace test_course_20_AbuHadhoud_Console.section20.part07
{
    public class Parameterized_Thread
    {
        public void Display()
        {
            Thread t1 = new Thread(() => Method1("Thread1"));
            t1.Start();
            Thread t2 = new Thread(() => Method2("Thread2"));
            t2.Start();

            //if i need to wait for finish of thread then execute main
            t1.Join();
            t2.Join();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.ReadKey();
        }

        private void Method1(string Parameter1)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{Parameter1} Method1: " + i);
                Thread.Sleep(1000);
            }
        }

        private void Method2(string Parameter2)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{Parameter2} Method2: " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
