using test_course_20_AbuHadhoud_Console.Section3.Part3;
using test_course_20_AbuHadhoud_Console.Section3.Part4;
using test_course_20_AbuHadhoud_Console.Section3.Part5;
using test_course_20_AbuHadhoud_Console.Section4.Part2;
using test_course_20_AbuHadhoud_Console.section7.part2;
using test_course_20_AbuHadhoud_Console.section8.part2;
using test_course_20_AbuHadhoud_Console.section8.part3;
using test_course_20_AbuHadhoud_Console.section8.part4;
using test_course_20_AbuHadhoud_Console.section10.part1;
using test_course_20_AbuHadhoud_Console.section10.part2;
using test_course_20_AbuHadhoud_Console.section10.part5;
using test_course_20_AbuHadhoud_Console.section10.part6;
using test_course_20_AbuHadhoud_Console.section10.part7;
using test_course_20_AbuHadhoud_Console.section13.part2;
using test_course_20_AbuHadhoud_Console.section13.part3;
using test_course_20_AbuHadhoud_Console.section14.part2;
using test_course_20_AbuHadhoud_Console.section14.part3;
using test_course_20_AbuHadhoud_Console.section15;
using test_course_20_AbuHadhoud_Console.section16;
using System.Configuration;
using test_course_20_AbuHadhoud_Console.section17;
using System.Diagnostics;
using test_course_20_AbuHadhoud_Console.section18.part4;
using test_course_20_AbuHadhoud_Console.section18.part8;
using test_course_20_AbuHadhoud_Console.section18.part11;

namespace test_course_20_AbuHadhoud_Console
{
    internal class Program
    {
        static void Main()
        {
            /*
                        //section 3 part 3
                        Thermostat thermostat = new Thermostat();
                        Display display = new Display();

                        display.Subscribe(thermostat);

                        thermostat.SetTemperature(25.0);
                        thermostat.SetTemperature(30.0);
                        thermostat.SetTemperature(28.0);
                        thermostat.SetTemperature(28.0);
                        thermostat.SetTemperature(32.0);

                        Console.ReadLine();
            */
            /*

                        //section 3 part 4
                        NewPublisher publisher = new NewPublisher();

                        NewSubscriber subscriber1 = new NewSubscriber("subscriber 1");
                        subscriber1.Subscribe(publisher);

                        NewSubscriber subscriber2 = new NewSubscriber("subscriber 2");
                        subscriber2.Subscribe(publisher);

                        publisher.PublishNews("Breaking News: C# 10 Released!", "Microsoft has announced the release of C# 10, bringing new features and improvements to the language.");

                        subscriber1.UnSubscribe(publisher);

                        publisher.PublishNews("Tech Update: AI Advancements in 2024", "The field of artificial intelligence continues to evolve rapidly, with new breakthroughs and applications emerging in 2024.");

                        subscriber2.UnSubscribe(publisher);

                        publisher.PublishNews("Global News: Climate Change Summit 2024", "World leaders gather for the Climate Change Summit 2024 to discuss strategies for combating global warming and promoting sustainability.");

            */



            /*
                        //section 3 part5
                        var order = new Order();

                        EmailService emailService = new EmailService();
                        SMSService smsService = new SMSService();
                        ShippingService shippingService = new ShippingService();

                        emailService.Subscribe(order);
                        smsService.Subscribe(order);
                        shippingService.Subscribe(order);
                        shippingService.Unsubscribe(order);

                        order.Create(1, 200, "Ahmed@gmail.com");
            */


            /*
                        //section 4 part 2
                        //constructor take a delegate as parameter
                        //to determine the logging method
                        //so the two function have the same signature of the delegate
                        //so we can pass them as parameter to the constructor
                        Logger ScreenLogger = new Logger(LogTo.LogToScreen);
                        Logger FileLogger = new Logger(LogTo.LogToFile);

                        ScreenLogger.Log("This message will be logged to the screen.");
                        FileLogger.Log("This message will be logged to a file.");

            */

            /*

                        //section 4 part 4 & part 5 & part 6 and section5 (lamba expression, Func, Action, Predicate)
                        //Func have a return type and can take parameters
                        Func<int, int, int> add = (a, b) => a + b;
                        Console.WriteLine( add.Invoke(5, 3)); // Output: 8

                        //Action have no return type and can take parameters
                        Action<string,string> printMessage = (message1, message2) => Console.WriteLine($"{message1} {message2}");
                        printMessage.Invoke("Hello", "World!"); // Output: Hello World!


                        //Predicate return a boolean value and can take parameters
                        Predicate<int> isEven = number => number % 2 == 0;
                        Console.WriteLine(isEven.Invoke(4)); // Output: true
            */


            /*
                        //section 7 prat 1
                        //Nullable Data Types
                        //int x = null; // This will cause a compile-time error because int is a value type and cannot be null
                        Nullable<int> nullableInt = null;

                        if (nullableInt.HasValue)
                        {
                            Console.WriteLine("nullableInt has a value: " + nullableInt.Value);
                        }
                        else
                        {
                            Console.WriteLine("nullableInt does not have a value.");
                        }

                        //if i don't use int? i will get an error because int is a value type and cannot be null
                        int? nullableInt2 = 5; //using shorthand syntax for nullable types

                        int result = nullableInt2 ?? 0; //if nullableInt has a value use it, otherwise use 0
                        Console.WriteLine("using null-coalescing operator: " + result);

                        //if nullableInt has a value convert it to string, otherwise use "No value"
                        string stringValue = nullableInt2?.ToString() ?? "No value";
                        Console.WriteLine("using null-conditional operator: " + stringValue);
            */
            /*
                        //section 7 part 2
                        Nullable_Datatypes_Example_2.Procedure1("Ahmed", null);
                        Nullable_Datatypes_Example_2.Procedure2("Mohamed",null);
            */


            /*
                        //section 8 part 2
                        XML_Serialization_Example example = new XML_Serialization_Example();
                        example.RunDemo();
                        Console.ReadLine();

            */
            /*
                        //section 8 part 3
                        //Json_Serialization_Example example = new Json_Serialization_Example();
                        Json_Serialization_Example json = new Json_Serialization_Example();
                        json.RunDemo();
            */
            /*
                        //section 8 part 4
                        //Binary_Serialization_Example binary = new Binary_Serialization_Example();
                        Binary_Serialization_Example binary = new Binary_Serialization_Example();
                        binary.RunDemo();
            */

            /*
                        //section 10 part1
                        TypeClass typeClass = new TypeClass();
                        typeClass.method();
            */

            /*
                        //section 10 part2
                        Navigate_String_Library_Using_Reflection_Example obj = new Navigate_String_Library_Using_Reflection_Example();
                        obj.Display();
            */
            /*
                        RwCustomAttributes obj = new RwCustomAttributes();
                        obj.Display();
            */

            /*
                        //section 10 part7
                        ValidationExample obj = new ValidationExample();
                        obj.Display();
            */

            /*
                        Generic_Methods generic_Methods = new Generic_Methods();
                        generic_Methods.Display();
            */
            /*
                        Generic_Classes generic_Classes = new Generic_Classes();
                        generic_Classes.Display();
            */
            /*
                        Writing_to_Registry obj = new Writing_to_Registry();
                        obj.Dispay();
            */


            /*
                        Reading_from_Registry obj = new Reading_from_Registry();
                        obj.Dispay();
            */
            /*
                        Logging_Example obj = new Logging_Example();
                        obj.Display();
            */

            /*
                        //section 16
                        string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                        string LogLevel = ConfigurationManager.AppSettings["LogLevel"];

                        string myDbConnection = ConfigurationManager.ConnectionStrings["DbName"].ConnectionString;


                        Console.WriteLine("\nConnectionString: " + connectionString);
                        Console.WriteLine("\nLogLevel: " + LogLevel);
                        Console.WriteLine("\nmyDbConnection: " + myDbConnection);

            */

            /*
                        What_is_String_Builder_and_Why obj = new What_is_String_Builder_and_Why();
                        int iterations = 1000000;

                        // Concatenating strings using +
                        Stopwatch stopwatch1 = Stopwatch.StartNew();
                        obj.ConcatenateStrings(iterations);
                        stopwatch1.Stop();
                        Console.WriteLine($"String concatenation using + took: {stopwatch1.ElapsedMilliseconds} ms");

                        // Concatenating strings using StringBuilder
                        Stopwatch stopwatch2 = Stopwatch.StartNew();
                        obj.ConcatenateStringBuilder(iterations);
                        stopwatch2.Stop();
                        Console.WriteLine($"String concatenation using StringBuilder took: {stopwatch2.ElapsedMilliseconds} ms");

                        Console.ReadKey();
            */
            /*
                        //section18 part4

                        Hashing_Example obj = new Hashing_Example();
                        obj.Display();

            */
/*
            //section18 part8
            Symmetric_Encryption_Example obj = new Symmetric_Encryption_Example();
            obj.Display();
*/

            Asymmetric_Encryption_Example obj = new Asymmetric_Encryption_Example();
            obj.Display();
        }
    }
}
