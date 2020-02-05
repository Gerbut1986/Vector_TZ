namespace Sortable_Shapes.Tests
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShapesTests
    {
        [TestMethod]
        public void ShapesAreSortableOnArea()
        {
            // Arrange:
            double width, height, triangleBase, side, radius;
            Random random = new Random((int)DateTime.UtcNow.Ticks);

            var expected = new List<Shape>();

            side = 1.1234;
            expected.Add(new Square(side));

            radius = 1.1234;
            expected.Add(new Circle(radius));

            triangleBase = 5;
            height = 2;
            expected.Add(new Triangle(triangleBase, height));

            height = 3;
            triangleBase = 4;
            expected.Add(new Triangle(triangleBase, height));

            width = 4;
            expected.Add(new Rectangle(width, height));

            var actual = expected.OrderBy(x => random.Next()).ToList();

            // Act:
            actual.Sort();

            // Assert:
            for (var i = 0; i < 5; i++)
                Assert.AreEqual(expected[i], actual[i]);
        }
    }
}
