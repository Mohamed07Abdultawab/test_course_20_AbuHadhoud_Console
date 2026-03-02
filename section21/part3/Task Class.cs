using System;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section21.part3
{
    public class Task_Class
    {
        public async Task Display()
        {
            Task<int> resultTask = PerformAsyncOperation();

            Console.WriteLine("Doing some work.");

            int result = await resultTask;//wait for task compelete 


            Console.WriteLine($"Result: {result}");
        }

        static async Task<int> PerformAsyncOperation()
        {
            await Task.Delay(2000);
            return 42;
        }
    }
}
