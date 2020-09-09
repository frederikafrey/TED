using System;

namespace Praktikum1
{
    internal class Point
    {
        private double x;
        private double y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        
        public Point (double setX, double setY)
        {
            x = setX;
            y = setY;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public double GetDistance(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
            return distance;
        }

        public double Rho()
        {
            double answer = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return answer;
        }

        public double Theta()
        {
            double answer = Math.Atan2(y, x);
            return answer;
        }

        public Point VectorTo(Point p)
        {
            Point answer = new Point(p.getX() - x, p.getY() - y);
            return answer;
        }
        //pre: x and y are type double
        //post: x() += x; y() += y;
        public void Translate(double newX, double newY)
        {
            newX += x;
            newY += y;
        }
        //pre:
        //post: x() = factor * x(); y() = factor* y();
        public void Scale(double factor)
        {
            x = factor * x;
            y = factor * y;
        }
        //inv: rho does not change
        //pre: angle is type double and in radians
        //post: theta() == old theta() + angle;
    }
}
