using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section13.part3
{

    public class GenericBox<B>
    {
        private B Content;

        public GenericBox(B Content)
        {
            this.Content = Content;
        }

        public B GetContent()
        {
            return this.Content;
        }
    }


    public class Generic_Classes
    {
        public void Display()
        {
            GenericBox<int> intBox = new GenericBox<int>(42);//like list
            Console.WriteLine("Content of intBox: " + intBox.GetContent()); // Outputs: 42


            GenericBox<string> stringBox = new GenericBox<string>("Hello, World!");
            Console.WriteLine("Content of stringBox: " + stringBox.GetContent()); // Outputs: Hello, World!
        }
    }

}
