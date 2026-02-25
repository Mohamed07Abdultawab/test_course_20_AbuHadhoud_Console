using System;
using System.Diagnostics;

namespace test_course_20_AbuHadhoud_Console.section15
{
    public class Logging_Example
    {
        public void Display()
        {

            //created sourse name if not found
            string sourceName = "kokoApp";
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source created.");
            }

            //log an information event
            EventLog.WriteEntry(sourceName, "This is my information :-).",EventLogEntryType.Information);
            EventLog.WriteEntry(sourceName, "This is my Warning :-).", EventLogEntryType.Warning);
            EventLog.WriteEntry(sourceName, "This is my Error :-).", EventLogEntryType.Error);

            Console.WriteLine("Event written to the log.");
        }
    }
}
