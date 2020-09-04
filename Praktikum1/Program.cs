using System;
using System.Drawing;

namespace Praktikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            PointCreator pointCreator = new PointCreator();
            Console.WriteLine(pointCreator.GetDistance().ToString());
        }
    }
}
