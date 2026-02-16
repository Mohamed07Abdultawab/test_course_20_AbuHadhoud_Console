using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace test_course_20_AbuHadhoud_Console.section8.part4
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Binary_Serialization_Example
    {
        public void RunDemo()
        {
/*
            Person person = new Person() { Name = "mohamed", Age = 20 };
            //is not used in .net core and .net 5 and later versions because of security issues
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream("person.bin", FileMode.Create))
            {
                formatter.Serialize(stream, person);
                Console.WriteLine("Data Saved.");
            }

            // Deserialization
            using (FileStream stream = new FileStream("person.bin", FileMode.Open))
            {
                Person deserializedPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
*/
        }
    }
}
