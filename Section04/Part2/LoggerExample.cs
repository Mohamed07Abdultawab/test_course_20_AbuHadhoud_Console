using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.Section4.Part2
{
   public class Logger
    {
        public delegate void LogAction(string message);// Define a delegate type for logging actions
        private LogAction logAction; // Field to hold the current logging action

        public Logger(LogAction action)
        {
            this.logAction = action;
        }

        public void ChangeMethod(LogAction action)
        {
            this.logAction = action;
        }

        public void Log(string message)
        {
            logAction.Invoke(message); // Invoke the current logging action
        }
    }

    public static class LogTo
    {
        public static void LogToScreen(string message)//same the signature of the delegate
        {
            Console.WriteLine(message);
        }

        public static void LogToFile(string message)//same the signature of the delegate
        {
            string FileName = "log.txt";
            using(StreamWriter writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
