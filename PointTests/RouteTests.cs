using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praktikum1;
using TAD1;

namespace TAD1Tests
{
    [TestClass]
    public class RouteTests
    {
        Route _testRoute = new Route();
        private Point p1;
        private Point p2;
        private Point p3;
        Random rnd = new Random();


        [TestInitialize]
        public void Initialize()
        {
            p1 = new Point(0,1);
            p2 = new Point(rnd.Next(0, 100), rnd.Next(0, 100));
            p3 = new Point(rnd.Next(0, 100), rnd.Next(0, 100));
        }

        [TestMethod]
        public void CreateRouteTest()
        {
            _testRoute.AddPoint(1,2,0);
            _testRoute.AddPoint(2,3,1);
            _testRoute.CreateRoute();
            Assert.AreEqual(0, _testRoute.GetLength());
        }
    }
}
