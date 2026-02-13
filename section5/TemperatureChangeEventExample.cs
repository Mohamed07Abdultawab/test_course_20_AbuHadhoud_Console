using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud.section5
{
    //bag
    public class TemperatureChangeEventArgs : EventArgs
    {
        public double OldTemperature { get; }
        public double NewTemperature { get; }
        public double Difference { get; }
        public TemperatureChangeEventArgs(double oldTemperature, double newTemperature)
        {
            OldTemperature = oldTemperature;
            NewTemperature = newTemperature;
            Difference = newTemperature - oldTemperature;
        }
    }



    public class Thermostat
    {
        // Define the event using EventHandler<T>
        public event EventHandler<TemperatureChangeEventArgs> TemperatureChanged;
        private double OldTemperature;
        private double currentTemperature;

        public void SetTemperature(double newTemperature)
        {
            if (newTemperature != currentTemperature)
            {
                OldTemperature = currentTemperature;
                currentTemperature = newTemperature;
                // Raise the event 
                OnTemperatureChanged(OldTemperature, currentTemperature);
            }
        }


        private void OnTemperatureChanged(double oldTemperature, double newTemperature)
        {
            TemperatureChanged?.Invoke(this, new TemperatureChangeEventArgs(oldTemperature, newTemperature));
        }

        protected virtual void OnTemperatureChanged(TemperatureChangeEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }


    public class Display
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.TemperatureChanged += HandelTemperatureChanged;
        }

        public void HandelTemperatureChanged(object sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine("\n\nTemperature changed:");
            Console.WriteLine($"Temperature changed from {e.OldTemperature}C");
            Console.WriteLine($"Temperature changed to {e.NewTemperature}C");
            Console.WriteLine($"Temperature Differance to {e.Difference}C");
        }
    }






}
