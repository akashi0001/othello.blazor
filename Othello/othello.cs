using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace othello;
public class Othello
{ 
    public static void reset()
    {
        Array.Fill(Board.board, " ");
        Board.board[44] = "black.png";
        Board.board[45] = "black.png";
        Board.board[54] = "black.png";
        Board.board[55] = "black.png";
    }
    public static void click(int i)
    {
        int c1 = Put.put(i, "black.png");
        if(c1 == 1) { Board.board[i] = "black.png"; }
        int c2 = Put.putcheck("white.png");
        if (c1 == 1&&c2 == 1)
        {
            Enemy.enemymove();
        }
    }
}