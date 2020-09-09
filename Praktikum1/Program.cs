using System;
using System.Drawing;

namespace Praktikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(10, 20);
            Point point2 = new Point(-20, 60);
            Console.WriteLine(point1.GetDistance(point2));

        }
    }
}
