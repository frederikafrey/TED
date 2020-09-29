using System;
using System.Collections.Generic;
using System.Text;
using Praktikum1;

namespace TAD1
{
    public class Route
    {
        readonly List<Point> _routePoints = new List<Point>();

        //POST: route.Count = 0
        public void CreateRoute()
        {
            _routePoints.Clear();
        }

        //PRE: 0 <= index 
        //POST: route[index] = routePoint
        //      routePoint(x, y)
        public void AddPoint(double x, double y, int index)
        {
            if (index >= 0)
            {
                Point routePoint = new Point(x, y);
                _routePoints.Insert(index, routePoint);
            }
        }

        //PRE: 0 <= index
        //POST: route[index] != old.route[index]
        public void RemovePoint(int index)
        {
            if (index >= 0)
            {
                _routePoints.RemoveAt(index);
            }
        }

        public double GetLength()
        {
            double length = 0;

            if (_routePoints.Count > 1)
            {
                for (int i = 0; i < _routePoints.Count - 1; i++)
                {
                    double distance = _routePoints[i].GetDistance(_routePoints[i + 1]);
                    length += distance;
                }
            }

            return length;
        }

    }

}
