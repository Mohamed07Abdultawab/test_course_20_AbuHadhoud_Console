using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section10.part6
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class kokoAttribute: Attribute
    {
        public string Description { get; }

        public kokoAttribute(string descrption)
        {
            Description = descrption;
        }

    }


    [koko("This is a class attribute")]
    class MyClass
    {
        [koko("This is a method attribute")]
        public void MyMethod()
        {

        }
    }

    public class RwCustomAttributes
    {
        public void Display()
        {
            // Get the type of MyClass
            Type type = typeof(MyClass);


            // Get class-level attributes
            object[] classAttributes = type.GetCustomAttributes(typeof(kokoAttribute), false);
            foreach (kokoAttribute attribute in classAttributes)
            {
                Console.WriteLine($"Class Attribute: {attribute.Description}");
            }


            // Get method-level attributes
            MethodInfo methodInfo = type.GetMethod("MyMethod");
            object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(kokoAttribute), false);
            foreach (kokoAttribute attribute in methodAttributes)
            {
                Console.WriteLine($"Method Attribute: {attribute.Description}");
            }

        }
    }
}
