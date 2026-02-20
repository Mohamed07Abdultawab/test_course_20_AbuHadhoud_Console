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
            //define serializer from json
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

            //write in json file with memory stream
            using (MemoryStream stream = new MemoryStream())
            {
                //serialize the object to the memory stream
                serializer.WriteObject(stream, person);
                //convert the memory stream to string
                string jsonString = Encoding.UTF8.GetString(stream.ToArray());
                //save the string to a file
                File.WriteAllText("person.json", jsonString);

                Console.WriteLine("Data Saved.");
            }

            // Deserialization
            using (FileStream stream = new FileStream("person.json", FileMode.Open))
            {
                //deserialize the object from the file stream
                Person deserializedPerson = (Person)serializer.ReadObject(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
        }
    }
}
