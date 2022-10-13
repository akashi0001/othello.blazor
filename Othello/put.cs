using System.Globalization;

namespace othello;

public class Put
{
    public static int Putcheck(int n, string c)
    {
        int j = 0;
        int b = 0;
        for(int i=0; i < 8; i++) { 
            switch(i)
            {
                case 0:
                    j = -9;
                    break;
                case 1:
                    j = -8;
                    break;
                case 2:
                    j = -7;
                    break;
                case 3:
                    j = -1;
                    break;
                case 4:
                    j = 1;
                    break;
                case 5:
                    j = 7;
                    break;
                case 6:
                    j = 8;
                    break;
                case 7:
                    j = 9;

                    break;
            }
            try
            {
                for(int now = n; now < 0 || now > 63; now += j) 
                {
                    if (Board.board[n]!=" ")
                    {
                        break;
                    }
                    if (Board.board[n + j] == c)
                    {
                        break;
                    }
                    if(Board.board[now]==" ")
                    {
                        break;
                    }
                    if (Board.board[now]==c)
                    {
                        if(j<0)
                        {for (now -= j; now > n; now -= j)
                            {
                                Board.board[now] = c;
                            }
                        }
                        if (j > 0)
                        {
                            for (now -= j; now < n; now -= j)
                            {
                                Board.board[now] = c;
                            }
                        }
                        b = 1;
                        break;
                    }

                }
            }
            catch (IndexOutOfRangeException) { }
            
        }
        return b;
        
    }

}