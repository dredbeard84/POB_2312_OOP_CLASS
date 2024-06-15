using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_05__тема_6_static_
{
    internal class Point
    {
        public double X { get; set; } // 1.1

        public double Y { get; set; } // 1.2

        public static int count = 0; // 1.3

        public Point(double x, double y) // 1.4
        {
            X = x;
            Y = y;
            count++;
        }

        public static double LengthPoints(Point p1, Point p2) // 2.1
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
