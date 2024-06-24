

using UnitTestingMsTestIntro;

namespace Tests
{
    [TestClass]
    public class CalcTests
    {
        [DataRow(5, 11, 16)]
        [DataRow(3, 9, 12)]
        [DataRow(15, 17, 32)]
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue(int a, int b, int expected)
        {
            // Arrange "This values are in DataRow decorator".           

            // Act
            int actual = Calcs.Add(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataRow(100, 50, 50)]
        [DataRow(4, 3, 1)]
        [DataRow(26, 11, 15)]
        [TestMethod]
        public void Subtract_ShouldCalcAndReturnSameValue(int a, int b, int expected)
        {
            // Arrange "This values are in DataRow decorator".           

            // Act
            int actual = Calcs.Subtract(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataRow(4, 8, 32)]
        [DataRow(5, 6, 30)]
        [DataRow(7, 8, 56)]
        [TestMethod]
        public void Multiply_ShouldCalcAndReturnSameValue(int a, int b, int expected)
        {
            // Arrange "This values are in DataRow decorator".           

            // Act
            int actual = Calcs.Multiply(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
