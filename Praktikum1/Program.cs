using System;
using System.Drawing;
using TAD1;

namespace Praktikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(10, 20);
            Point point2 = new Point(-20, 60);
            Console.WriteLine(point1.GetDistance(point2));

            Route route = new Route();
            route.AddPoint(0,1, 0);
            route.AddPoint(1,1,1);
            route.RemovePoint(1);
            route.AddPoint(1, 1, 1);

            Console.WriteLine(route.GetLength());
        }
    }
}
