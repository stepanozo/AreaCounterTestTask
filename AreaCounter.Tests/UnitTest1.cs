namespace AreaCounter.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCircleArea()
        {
            int radius = 5;

            double expected = Math.Pow(radius, 2) * Math.PI;
            double actual = new Circle(radius).Area;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            double a = 5;
            double b = 8;
            double c = 10;
            double p = (a + b + c) / 2;

            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double actual = new Triangle(a, b, c).Area;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRectangular()
        {
            int a = 4;
            int b = 3;
            int c = 5;

            bool expected = true;
            bool actual = new Triangle(a, b, c).IsRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}