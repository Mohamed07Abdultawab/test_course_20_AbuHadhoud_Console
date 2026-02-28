using System;
using System.Net;
using System.Threading;

namespace test_course_20_AbuHadhoud_Console.section20.part08
{
    public class Download_3_Web_Pages_using_Multi_Threading
    {
        public void Display()
        {
            Console.WriteLine("Starting threads...");

            Thread t1 = new Thread(() => DownloadAndPrint("https://www.cnn.com"));
            t1.Start();
            Console.WriteLine("Thread 1 started...");

            Thread t2 = new Thread(() => DownloadAndPrint("https://www.google.com"));
            t2.Start();
            Console.WriteLine("Thread 2 started...");

            Thread t3 = new Thread(() => DownloadAndPrint("https://www.ProgrammingAdvices.com"));
            t3.Start();
            Console.WriteLine("Thread 3 started...\n");


            t1.Join();
            t2.Join();
            t3.Join();


            Console.WriteLine("\nDone all threads finished execution.");
            Console.ReadKey();
        }


        static void DownloadAndPrint(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // السطر السحري اللي هيحل المشكلة:
                    client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                    // تحميل محتوى الصفحة
                    string content = client.DownloadString(url);
                    Console.WriteLine($"{url}: {content.Length} characters downloaded");
                }
            }
            catch (WebException ex)
            {
                // عشان لو موقع واحد وقع، الباقي يكمل وميوقفش البرنامج
                Console.WriteLine($"Error downloading {url}: {ex.Message}");
            }

        }
    }
}
