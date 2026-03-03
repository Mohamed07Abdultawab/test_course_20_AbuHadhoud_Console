using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using test_course_20_AbuHadhoud_Console.Section3.Part4;

namespace test_course_20_AbuHadhoud_Console.section21.part4
{
    public class Task_Class_Example_2
    {
        public async Task Display()
        {
            Console.WriteLine("Starting tasks...");

            Task t1 = DownloadAndPrintAsync("https://www.cnn.com");
            Console.WriteLine("Task 1 started...");

            Task t2 = DownloadAndPrintAsync("https://www.google.com");
            Console.WriteLine("Task 2 started...");

            Task t3 = DownloadAndPrintAsync("https://www.youtube.com");
            Console.WriteLine("Task 3 started...");

            await Task.WhenAll(t1, t2, t3);
            Console.WriteLine("All tasks completed");
        }

        static async Task DownloadAndPrintAsync(string url)
        {
            string content;

            using (WebClient client = new WebClient())
            {
                await Task.Delay(100);
                content = await client.DownloadStringTaskAsync(url);
            }
            Console.WriteLine($"{url}: {content.Length} characters downloaded");
        }
    }
}
