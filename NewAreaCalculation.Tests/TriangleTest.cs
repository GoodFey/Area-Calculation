using AreaCalculation;

namespace NewAreaCalculation.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalcArea_3_4_5_6returnted()
        {
            // arrange
            var expected = 6;

            // act
            Triangle newTriangle = new Triangle(3, 4, 5);
            var actual = newTriangle.CalcArea();

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}