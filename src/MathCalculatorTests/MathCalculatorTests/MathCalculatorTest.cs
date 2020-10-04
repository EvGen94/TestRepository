using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTest
    {
        private const int Five = 5;
        private const int Three = 3;

        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
            // Arrange
            MathCalculator calculator = new MathCalculator();

            // Act
            var result = calculator.Sum(Five, Three);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void WhenSubThreeFromFiveThenGotTwo()
        {
            // Arrange
            MathCalculator calculator = new MathCalculator();

            // Act
            var result = calculator.Sub(Five, Three);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
