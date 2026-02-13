using test_course_20_AbuHadhoud.section5;

namespace test_course_20_AbuHadhoud_Console
{
    internal class Program
    {
        static void Main()
        {
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
        }
    }
}
