using test_course_20_AbuHadhoud_Console.Section3.Part3;
using test_course_20_AbuHadhoud_Console.Section3.Part4;

namespace test_course_20_AbuHadhoud_Console
{
    internal class Program
    {
        static void Main()
        {
            /*
                        //section 5
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


            //section 6
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


        }
    }
}
