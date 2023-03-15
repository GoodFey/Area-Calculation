using AreaCalculation;

namespace NewAreaCalculation.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalcArea_5_78returnted()
        {
            // arrange
            var expected = 79;

            // act
            Circle newCircle = new Circle(5);
            var actual = newCircle.CalcArea();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalcArea_18_1017returnted()
        {
            // arrange
            var expected = 1017;
            ;
            // act
            Circle newCircle2 = new Circle(18);
            var actual = newCircle2.CalcArea();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}