using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section10.part7
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute: Attribute
    {

        public int Min { get; }
        public int Max { get; }
        
        public string ErrorMessage { get; set; }
        public RangeAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }

    public class Person
    {
        [Range(18,99, ErrorMessage = "Age must be between 18 and 99.")]
        public int Age { get; set; }

        [Range(5,60, ErrorMessage = "Experience must be between 5 and 60.")]
        public int Experience { get; set; } 

        public string Name { get; set; }
    }


    public class ValidationExample
    {
        public void Display()
        {
            Person person = new Person { Name = "John", Age = 25, Experience = 10 };
            if (ValidatePerson(person))
            {
                Console.WriteLine("Person is valid.");
            }
        }

        static bool ValidatePerson(Person person)
        {
            Type type = typeof(Person);
            foreach(var property in type.GetProperties())
            {
                var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
                if (rangeAttribute != null)
                {
                    int value = (int)property.GetValue(person);

                    //perform validation
                    if(value < rangeAttribute.Min || value > rangeAttribute.Max)
                    {
                        Console.WriteLine($"Validation failed for {property.Name}: {rangeAttribute.ErrorMessage}");
                        return false;
                    }
                }
            }
            return true;
        }
        
    }
}
