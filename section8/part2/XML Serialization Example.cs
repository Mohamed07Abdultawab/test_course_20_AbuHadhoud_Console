using System;
using System.IO;
using System.Xml.Serialization;

namespace test_course_20_AbuHadhoud_Console.section8.part2
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class XML_Serialization_Example
    {
        // قمنا بوضع الكود داخل دالة (Method) لكي يمكن استدعاؤها
        public void RunDemo()
        {
            Person person = new Person() { Name = "mohamed", Age = 20 };

            // 1. Serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            // يفضل استخدام مسار كامل أو التأكد من مكان الملف، هنا سيتم حفظه بجانب ملف الـ exe
            string fileName = "person.xml";

            using (TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, person);
                Console.WriteLine("Data Saved to person.xml");
            }

            // 2. Deserialization
            using (TextReader reader = new StreamReader(fileName))
            {
                Person deserializedPerson = (Person)serializer.Deserialize(reader);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
        }
    }
}