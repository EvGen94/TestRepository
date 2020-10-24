using System;

namespace RockScissorsPaperLib
{
    public class DefaultChecker : IWinnerChecker
    {
        public WinResult Check(Variants player1, Variants player2){
            switch (player1)
            {
                case Variants.Rock:
                    return player2 == Variants.Paper ? WinResult.Player2Win : player2 == Variants.Scissors ? WinResult.Player1Win : WinResult.Draw;
                case Variants.Scissors:
                    return player2 == Variants.Rock ? WinResult.Player2Win : player2 == Variants.Paper ? WinResult.Player1Win : WinResult.Draw;
                case Variants.Paper:
                    return player2 == Variants.Scissors ? WinResult.Player2Win : player2 == Variants.Rock ? WinResult.Player1Win : WinResult.Draw;
                default:
                    throw new Exception($"Unexpected case player1:{player1} player2:{player2}");
            }
        }
    }
}
