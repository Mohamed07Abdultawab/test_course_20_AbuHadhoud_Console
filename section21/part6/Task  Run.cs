using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section21.part6
{
    public class Task__Run
    {
        public async Task Display()
        {
            //new thread for one 
            Task task1 = Task.Run(() => DownloadFile("Download File 1"));
            Task task2 = Task.Run(() => DownloadFile("Download File 2"));

            await  Task.WhenAll(task1, task2);

            Console.WriteLine("Task1 and Task2 completed.");
        }

        static void DownloadFile(string taskName)
        {
            Console.WriteLine($"{taskName}: Started!");
            Thread.Sleep(5000);
            Console.WriteLine($"{taskName}: Completed!");
        }
    }
}
