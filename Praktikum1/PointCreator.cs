using System;

namespace Praktikum1
{
    class PointCreator
    {
        public CustomPoint point1 = new CustomPoint();
        public CustomPoint point2 = new CustomPoint();
        public PointCreator ()
        {
            PointCoordinates();
        }

        public double GetDistance()
        {
            var distance = Math.Sqrt(Math.Pow(point1.getX() - point2.getX(), 2) + Math.Pow(point1.getY() - point2.getY(), 2));
            return distance;
        }

        public void PointCoordinates()
        {
            Console.WriteLine("Write X coordinate for your first point:");
            point1.setX(int.Parse(Console.ReadLine()));

            Console.WriteLine("Write Y coordinate for your first point:");
            point1.setY(int.Parse(Console.ReadLine()));

            Console.WriteLine("Write X coordinate for your second point:");
            point2.setX(int.Parse(Console.ReadLine()));

            Console.WriteLine("Write Y coordinate for your second point:");
            point2.setY(int.Parse(Console.ReadLine()));
        }

    }

    class CustomPoint
    {
        private int x;
        private int y;

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }

}
