namespace RockScissorsPaperLib
{
    public interface IWinnerChecker
    {
        WinResult Check(Variants Player1, Variants Player2);
    }  

    public enum WinResult
    {
        Player1Win,
        Player2Win,
        Draw
    } 

    public enum Variants
    {
        Rock,
        Scissors,
        Paper
    }
}