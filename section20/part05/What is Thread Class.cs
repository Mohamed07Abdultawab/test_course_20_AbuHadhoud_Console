using System;
using System.Threading;

namespace test_course_20_AbuHadhoud_Console.section20.part05
{
    public class What_is_Thread_Class
    {
        public void Display()
        {
            Thread t = new Thread(Method1);
            t.Start();
            Thread t2 = new Thread(Method2);
            t2.Start();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.ReadKey();
        }

        private void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread Method1: " + i);
                Thread.Sleep(1000);
            }
        }

        private void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread Method2: " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
