using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section9.part2
{
    [Serializable]
    public class serializable_attributes
    {
        public int y;

        [NonSerialized]
        public int x;
    }
}
