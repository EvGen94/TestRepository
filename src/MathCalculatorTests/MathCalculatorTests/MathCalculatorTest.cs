using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTest
    {
        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
            // Arrange
            const int Five = 5;
            const int Three = 3;
            MathCalculator calculator = new MathCalculator();

            // Act
            var result = calculator.Sum(5, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
