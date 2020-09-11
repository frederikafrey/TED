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

        [TestMethod]
        public void RhoTest()
        {
            double actual = Math.Sqrt(Math.Pow(p1.getX(), 2) + Math.Pow(p1.getY(), 2));
            double expected = p1.Rho();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThetaTest()
        {
            double actual = Math.Atan2(p2.getY(), p2.getX());
            double expected = p2.Theta();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VectorToTest()
        {
            Point testPoint = p1.VectorTo(p2);
            Assert.AreEqual(testPoint.getX(), p2.getX() - p1.getX());
            Assert.AreEqual(testPoint.getY(), p2.getY() - p1.getY());
        }

        [TestMethod]
        public void TranslateTest()
        {
            double oldX = p1.getX();
            double oldY = p1.getY();
            p1.Translate(2, 2);
            Assert.AreEqual(oldX + 2, p1.getX());
            Assert.AreEqual(oldY + 2, p1.getY());
        }

        [TestMethod]
        public void ScaleTest()
        {
            double oldX = p2.getX();
            double oldY = p2.getY();
            p2.Scale(3);
            Assert.AreEqual(oldX * 3, p2.getX());
            Assert.AreEqual(oldY * 3, p2.getY());
        }

        [TestMethod]
        public void CentreRotateTest()
        {
            Point temp = new Point(15, 0);
            temp.CentreRotate(Math.PI / 3);
            Assert.AreEqual(temp.getY(), 13, 0.1);
            Assert.AreEqual(temp.getX(), 7.5, 0.1);
        }

        [TestMethod]
        public void RotateTest()
        {
            Point temp = new Point(15, 0);
            Point temp1 = new Point(10, 10);
            Assert.AreEqual(temp.Theta(), 0);
            temp.Rotate(temp1, Math.PI / 4);
            Assert.AreEqual(temp.getX(), 20.6, 0.1);
            Assert.AreEqual(temp.getY(), 6.5, 0.1);
        }
    }
}
