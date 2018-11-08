using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Shapes.Tests
{
    [TestClass]
    public class ShapesTest
    {
        [TestMethod]
        public void CircleArea()
        {
            var circe = new Circle(2);
            var circleArea = 2 * 2 * Math.PI;

            Assert.AreEqual(circleArea, circe.Area);
        }

        [TestMethod]
        public void TriangleArea()
        {
            var AB = 3;
            var BC = 4;
            var AC = 5;
            var p = (AB + BC + AC) / 2;
            var triangleArea = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            var triangle = new Triangle(AB, BC, AC);

            Assert.AreEqual(triangleArea, triangle.Area);
        }

        [TestMethod]
        public void CheckTypeOfTriangle()
        {
            var triangleTrue = new Triangle(3, 5, 4);
            var triangleFalse = new Triangle(5, 5, 4);

            Assert.AreEqual(true, triangleTrue.IsTriangleRectangular);
            Assert.AreEqual(false, triangleFalse.IsTriangleRectangular);
        }

        [TestMethod]
        public void AreaWithoutType()
        {
            IShape shape = new Circle(3);
            var circleArea = 3 * 3 * Math.PI;
            Assert.AreEqual(circleArea, shape.Area);
        }
    }
}
