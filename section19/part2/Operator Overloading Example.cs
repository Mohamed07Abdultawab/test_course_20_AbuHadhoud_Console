using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section19.part2
{
    public class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //overloading +
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
        //overloading -
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        //==
        public static bool operator == (Point a, Point b)
        {
            return((a.X == b.X) && (a.Y == b.Y));
        }
        //!=
        public static bool operator != (Point a, Point b)
        {
            return((a.X != b.X) || (a.Y != b.Y));
        }

        //to string
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
    public class Operator_Overloading_Example
    {
        public void Display()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);

            Point p3 = p1 + p2;
            Point p4 = p2 - p3;

            Console.WriteLine($"Point1 : {p1.ToString()}");
            Console.WriteLine($"Point2 : {p2.ToString()}");
            Console.WriteLine($"Point3 is the result of point1 + point2: {p3.ToString()}");
            Console.WriteLine($"Point4 is the result of point1 - point2: {p4.ToString()}");


            // Using the overloaded == operator for point equality
            if (p1 == p2)
                Console.WriteLine("Using == : Yes, Point1 = Point2");
            else
                Console.WriteLine("Using == : No, Piont1 does not equal Point2");

            // Using the overloaded != operator for point inequality
            if (p1 != p2)
                Console.WriteLine("Using != : Yes, Piont1 does not equal Point2");
            else
                Console.WriteLine("Using != : No, Piont1 = Point2");

            Console.ReadKey();
        }
    }
}
