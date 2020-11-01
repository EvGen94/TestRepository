using System.Collections.Generic;
using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTestsSimple
    {
        [Fact]
        public void CallsTests()
        {
            CheckTest(Variants.Rock, Variants.Paper, WinResult.Player2Win);
        }

        public void CheckTest(Variants player1, Variants player2, WinResult expectedResult)
        {
            // Arrange
            IWinnerChecker winnerChecker = new DefaultChecker();
            
            // Act
            var result = winnerChecker.Check(player1, player2);

            // Assert
            Assert.Equal(expectedResult, result);  
        }

        [Theory]
        [InlineData(Variants.Rock, Variants.Paper, WinResult.Player2Win)]
        [InlineData(Variants.Rock, Variants.Scissors, WinResult.Player1Win)]
        [InlineData(Variants.Rock, Variants.Rock, WinResult.Draw)]
        public void CheckTestTheory(Variants player1, Variants player2, WinResult expectedResult)
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
