using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section10.part2
{
    public class Navigate_String_Library_Using_Reflection_Example
    {
        public void Display()
        {
            //get assemply that contain system.string
            Assembly mscorilb = typeof(string).Assembly;

            //get system.string type
            Type stringType = mscorilb.GetType("System.String");

            if(stringType != null )
            {
                Console.WriteLine("Methods of the System.String class:\n");

                //get all public methods of the system.string class
                var stringMethods = stringType.GetMethods(BindingFlags.Public | BindingFlags.Instance).OrderBy(m => m.Name);

                foreach(var method in  stringMethods)
                {
                    //return the format of all method 
                    // return type + name + parametar
                    Console.WriteLine($"\t{method.ReturnType} {method.Name}({GetParameterList(method.GetParameters())})");
                }

            }
            else
            {
                Console.WriteLine("System.String type not found.");
            }

            Console.ReadKey();
        }

        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(p => $"{p.ParameterType} {p.Name}"));
        }
    }
}
