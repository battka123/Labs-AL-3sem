using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab1.Tests
{
    [TestClass]
    public class lab1_test_task2
    {
        [TestMethod]
        public void ConstructTest()
        {
            Rectangle rectangle_ = new Rectangle(4, 5);
            Assert.AreEqual(20, rectangle_.Area);

            rectangle_.side1 = 1.5;
            rectangle_.side2 = 8;
            Assert.AreEqual(12, rectangle_.Area);
        }
        [TestMethod]
        public void NegativeTest()
        {
            Rectangle rectangle_ = new Rectangle(4, -5);
            Assert.AreEqual(0, rectangle_.Area);

            rectangle_.side1 = -1.5;
            rectangle_.side2 = -16;
            Assert.AreEqual(0, rectangle_.Area);

            rectangle_.side1 = 0;
            rectangle_.side2 = -7;
            Assert.AreEqual(0, rectangle_.Area);
        }
    }

    [TestClass]
    public class lab1_test_task3
    {
        [TestMethod]

        public void LengthSide_Test()
        {
            Point p1 = new Point(0, 1);
            Point p2 = new Point(6, 9); // 36 + 64 = 100
            Point p3 = new Point(10, 12); //  16 + 9 = 25
            Figure figure = new Figure(p1, p2, p3);

            Assert.AreEqual(10, figure.LengthSide(p1, p2));
            Assert.AreEqual(5, figure.LengthSide(p2, p3));
        }

        // Если тип возвращаемого значения будет double у метода PerimeterCalculator,
        // тогда можно проверить через сравнение Assert.AreEqual
        [TestMethod]
        public void PerimeterCalculator_Test()
        {
            Point p1 = new Point(0, 1);
            Point p2 = new Point(1, 1);
            Point p3 = new Point(0, 1);
            Point p4 = new Point(0, 0);
            Point p5 = new Point(0, 1);
            {
                Figure figure3 = new Figure(p1, p2, p3, name: "Треугольник");
                Assert.AreEqual(2, figure3.PerimeterCalculator());
            }
            {
                Figure figure4 = new Figure(p1, p2, p3, p4, name: "Четырёхугольник");
                Assert.AreEqual(4, figure4.PerimeterCalculator());
            }
            {
                Figure figure5 = new Figure(p1, p2, p3, p4, p5, name: "Пятиугольник");
                Assert.AreEqual(4, figure5.PerimeterCalculator());
            }
        }


    }
}
