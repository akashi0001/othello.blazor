namespace othello;

public class Board
{
    public static string[] board = Enumerable.Repeat("black.png", 64).ToArray();
    

    public static int[] priority =
    {
        8,2,7,5,5,7,2,8,
        2,1,3,3,3,3,1,2,
        7,3,6,4,4,6,3,7,
        5,3,4,4,4,4,3,5,
        5,3,4,4,4,4,3,5,
        7,3,6,4,4,6,3,7,
        2,1,3,3,3,3,1,2,
        8,2,7,5,5,7,2,8,
    };
}