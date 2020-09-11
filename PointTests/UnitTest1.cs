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
        public void TestMethod1()
        {
        }
    }
}
