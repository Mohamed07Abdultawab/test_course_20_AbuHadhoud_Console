using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace test_course_20_AbuHadhoud_Console.section8.part3
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Json_Serialization_Example
    {
        public void RunDemo()
        {
            Person person = new Person() { Name = "mohamed", Age = 20 };
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, person);
                string jsonString = Encoding.UTF8.GetString(stream.ToArray());

                File.WriteAllText("person.json", jsonString);

                Console.WriteLine("Data Saved.");
            }

            // Deserialization
            using (FileStream stream = new FileStream("person.json", FileMode.Open))
            {
                Person deserializedPerson = (Person)serializer.ReadObject(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
        }
    }
}
