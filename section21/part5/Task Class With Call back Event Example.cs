using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section21.part5
{
    public class CustomEventArgs: EventArgs
    {
        public int Parameter1 { get; }
        public string Parameter2 { get; }

        public CustomEventArgs(int param1,string param2)
        {
            Parameter1 = param1;
            Parameter2 = param2;
        }
    }
    public class Task_Class_With_Call_back_Event_Example
    {
        public delegate void CallbackEventHandler(object sender, CustomEventArgs e);
        public static event CallbackEventHandler CallBackEvent;

        public async Task Display()
        {
            CallBackEvent += OnCallbackReceived;

            Task performTask = PerformAsyncOperation(CallBackEvent);

            Console.WriteLine("Doing some work...");

            await performTask;

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        static async Task PerformAsyncOperation(CallbackEventHandler callBackEvent)
        {
            await Task.Delay(1000);

            CustomEventArgs eventArgs = new CustomEventArgs(42, "Hello from event");

            callBackEvent?.Invoke(null, eventArgs);
        }

        static void OnCallbackReceived(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Event received: Parameter1: {e.Parameter1}, Parameter2: {e.Parameter2}");
        }
    }
}
