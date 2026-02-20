#define koko


using System;
using System.Diagnostics;





namespace test_course_20_AbuHadhoud_Console.section9.part3
{
    public class Conditional_Attribute_Examples
    {
        [Conditional("koko")]//will print in main function if you define koko
        public static void LogTrace(string message)
        {
            Console.WriteLine($"[Trace] {message}");
        }
    }
}
