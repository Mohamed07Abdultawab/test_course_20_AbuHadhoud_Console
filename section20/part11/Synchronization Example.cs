using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section20.part11
{
    public class Synchronization_Example
    {
        static int sharedCounter = 0;
        static object lockObject = new object();
        public void Display()
        {
            Thread t1 = new Thread(IncrementCounter);
            Thread t2 = new Thread(IncrementCounter);
            Thread t3 = new Thread(IncrementCounter);
            Thread t4 = new Thread(IncrementCounter);
            Thread t5 = new Thread(IncrementCounter);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();


            Console.WriteLine("Final Counter Value: " + sharedCounter);
            Console.ReadKey();
        }

        static void IncrementCounter()
        {
            for(int i =0;i< 100000; i++)
            {
                lock (lockObject)
                {
                    sharedCounter++;
                }
            }
        }

        

    }
}
