using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase01()
        {
            Triangle triangle = new Triangle();
            float result = triangle.findArea(3, 4, 5);
            Assert.AreEqual(result, 6);

        }

        [TestMethod]
        public void TestCase02()
        {
            Triangle triangle = new Triangle();
            float result = triangle.findArea(7, 5, 10);
            Assert.AreEqual(result, 16.25);
        }

        [TestMethod]
        public void TestCase03()
        {
            Triangle triangle = new Triangle();
            float result = triangle.findArea(10, 6, 8);
            Assert.AreEqual(result, 24);
        }

        [TestMethod]
        public void TestCase04()
        {
            Triangle triangle = new Triangle();
            var ex = Assert.ThrowsException<Exception>(() => triangle.findArea(10, -6, 8));
            Assert.AreSame(ex.Message, "Dimention must be positive values, Not a valid triangle!");

        }

        [TestMethod]
        public void TestCase05()
        {
            Triangle triangle = new Triangle();
            var ex = Assert.ThrowsException<Exception>(() => triangle.findArea(3, 4, -5));
            Assert.AreSame(ex.Message, "Dimention must be positive values, Not a valid triangle!");

        }

        [TestMethod]
        public void TestCase06()
        {
            Triangle triangle = new Triangle();
            var ex = Assert.ThrowsException<Exception>(() => triangle.findArea(100, 6, 8));
            Assert.AreSame(ex.Message, "Not a valid triangle!");

        }

        [TestMethod]
        public void TestCase07()
        {
            Triangle triangle = new Triangle();
            var ex = Assert.ThrowsException<Exception>(() => triangle.findArea(10, 400, 50));
            Assert.AreSame(ex.Message, "Not a valid triangle!");

        }
    }
}
