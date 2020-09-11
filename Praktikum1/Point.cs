using System;

namespace Praktikum1
{
    public class Point
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

        //PRE: IsDouble(newX) AND IsDouble(newY)
        //POST: getX() += newX; getY() += newY;
        public void Translate(double newX, double newY)
        {
            x += newX;
            y += newY;
        }

        //PRE: 
        //POST: getX() = factor * getX() AND getY() = factor* getY();
        public void Scale(double factor)
        {
            x = factor * x;
            y = factor * y;
        }

        //INV: Rho() == old Rho()
        //PRE: IsDouble(angle) AND angle is in radians
        //POST: theta() == old theta() + angle;
        public void CentreRotate(double angle)
        {
            double tempX = Rho() * Math.Cos(Theta() + angle);
            double tempY = Rho() * Math.Sin(Theta() + angle);
            x = tempX;
            y = tempY;
        }

        //PRE: 
        //POST: p.VectorTo(this).Theta() == p.VectorTo(old.this).Theta() + angle
        public void Rotate(Point p, double angle)
        {
            Translate(-p.x, -p.y);
            CentreRotate(angle);
            Translate(p.x, p.y);
        }
    }
}
