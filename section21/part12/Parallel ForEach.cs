using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using test_course_20_AbuHadhoud_Console.Section3.Part3;

namespace test_course_20_AbuHadhoud_Console.section21.part12
{
    public class Parallel_ForEach
    {
        static List<string> urls = new List<string>
        {
            "https://www.google.com",
            "https://www.youtube.com",
            "https://www.amazon.com",
        };
        public void Display()
        {
            Parallel.ForEach(urls, url =>
            {
                string content;
                using (WebClient webClient = new WebClient())
                {
                    Thread.Sleep(1000);
                    content = webClient.DownloadString(url);
                }
                Console.WriteLine($"{url}: {content.Length} characters downloaded");
            });
        }
    }
}
