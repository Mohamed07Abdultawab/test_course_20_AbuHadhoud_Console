using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section17
{
    public class What_is_String_Builder_and_Why
    {
        public void ConcatenateStrings(int iterations)
        {
            string result = "";
            for (int i = 0; i < iterations; i++)
            {
                result += "a";
            }
        }

        public void ConcatenateStringBuilder(int iterations)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");

            }
            string result = sb.ToString();
        }
    }
}
