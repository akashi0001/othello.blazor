namespace othello;

public class Board
{
    public static string[] board =
    {
        "0","0","0","0","0","0","0","0","0","0",
        "0"," "," "," "," "," "," "," "," ","0",
        "0"," "," "," "," "," "," "," "," ","0",
        "0"," "," "," "," "," "," "," "," ","0",
        "0"," "," "," ","black.png","white.png"," "," "," ","0",
        "0"," "," "," ","white.png","black.png"," "," "," ","0",
        "0"," "," "," "," "," "," "," "," ","0",
        "0"," "," "," "," "," "," "," "," ","0",
        "0"," "," "," "," "," "," "," "," ","0",
        "0","0","0","0","0","0","0","0","0","0",
    };
    

    public static int[] priority =
    {
        0,0,0,0,0,0,0,0,0,0,
        0,8,2,7,5,5,7,2,8,0,
        0,2,1,3,3,3,3,1,2,0,
        0,7,3,6,4,4,6,3,7,0,
        0,5,3,4,4,4,4,3,5,0,
        0,5,3,4,4,4,4,3,5,0,
        0,7,3,6,4,4,6,3,7,0,
        0,2,1,3,3,3,3,1,2,0,
        0,8,2,7,5,5,7,2,8,0,
        0,0,0,0,0,0,0,0,0,0,
    };
}