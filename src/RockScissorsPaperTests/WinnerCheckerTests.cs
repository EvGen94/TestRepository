using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTests
    {
        [Theory]
        [InlineData(Variants.Rock, Variants.Paper, WinResult.Player2Win)]
        public void Test1(Variants player1, Variants player2, WinResult expectedResult)
        {
            // Arrange
            IWinnerChecker winnerChecker = new DefaultChecker();
            
            // Act
            var result = winnerChecker.Check(player1, player2);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
