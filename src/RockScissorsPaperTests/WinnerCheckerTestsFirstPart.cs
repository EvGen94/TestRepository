using System.Collections.Generic;
using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTestsSimple
    {
        [Fact]
        public void RockBeatenByPaper()
        {
            // Arrange
            IWinnerChecker winnerChecker = new DefaultChecker();
            
            // Act
            var result = winnerChecker.Check(Variants.Rock, Variants.Paper);

            // Assert
            Assert.Equal(WinResult.Player2Win, result);   
        }
    }
}
