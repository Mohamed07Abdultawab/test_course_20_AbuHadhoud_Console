using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section21.part7
{
    internal class Introduction_to_Task_Factory_Class
    {
        public void Display()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            TaskFactory taskFactory = new TaskFactory(
                token,
                TaskCreationOptions.AttachedToParent,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default
                );


            Task task1 = taskFactory.StartNew(() =>
            {
                Console.WriteLine("task 1 is running");
                Thread.Sleep(2000);
                Console.WriteLine("Task 1 completed");
            });

            Task task2 = taskFactory.StartNew(() =>
            {
                Console.WriteLine("task 2 is running");
                Thread.Sleep(1000);
                Console.WriteLine("Task 2 completed");
            });

            try
            {
                Task.WaitAll(task1, task2);
                Console.WriteLine("All tasks completed.");
            }
            catch (AggregateException ae)
            {
                foreach(var e in ae.InnerExceptions)
                    Console.WriteLine($"Exception: {e.Message}");
            }

            cts.Dispose();
        }
    }
}
