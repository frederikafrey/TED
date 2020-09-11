using System;
using Praktikum1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PointTests
{
    [TestClass]
    public class PointTests
    {
        Point p1;
        Point p2;
        Random rnd = new Random();

        [TestInitialize]
        public void Initialize()
        {
            p1 = new Point();
            p2 = new Point(rnd.Next(0, 100), rnd.Next(0, 100));
        }

        [TestMethod]
        public void XTest()
        {
            var p1X = p1.getX();
            Assert.IsNotNull(p1X);
            Assert.AreEqual(p1X, 0);
        }

        [TestMethod]
        public void YTest()
        {
            var p1Y = p1.getY();
            Assert.IsNotNull(p1Y);
            Assert.AreEqual(p1Y, 0);
        }

        [TestMethod]
        public void GetDistanceTest()
        {
            double actual = Math.Sqrt(Math.Pow(p1.getX() - p2.getX(), 2) + Math.Pow(p1.getY() - p2.getY(), 2));
            double expected = p1.GetDistance(p2);
            Assert.AreEqual(expected, actual);
        }
    }
}
