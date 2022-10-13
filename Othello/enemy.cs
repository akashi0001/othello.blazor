namespace othello;

public class Enemy
{
    public static void enemymove()
    {
        
        int c1 = 0;
        int c2 = 0;
        while (c2 == 0) {
            for (int f = 8; f > 0; f--)
            {
                for (int i = 11; i < 89; i++)
                {
                    if (Board.priority[i] == f) { c1 = Put.put(i, "white.png"); }
                    if (c1 == 1) {
                        Board.board[i] = "white.png";
                        break; }
                }
                if (c1 == 1) { break; }
            }
            c2 = Put.putcheck("black.png");
            if (c2 == 0) 
            {
                c2 = Put.putcheck("white.png");
                if (c2 == 0) { c2 = 1; }
            }
            c1 = 0;
        }
    }
}