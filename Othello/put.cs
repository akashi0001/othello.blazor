using System.Globalization;

namespace othello;

public class Put
{
    public static int put(int n, string c)
    {
        int j = 0;
        int b = 0;
        for(int i=0; i < 8; i++) { 
            switch(i)
            {
                case 0:
                    j = -11;
                    break;
                case 1:
                    j = -10;
                    break;
                case 2:
                    j = -9;
                    break;
                case 3:
                    j = -1;
                    break;
                case 4:
                    j = 1;
                    break;
                case 5:
                    j = 9;
                    break;
                case 6:
                    j = 10;
                    break;
                case 7:
                    j = 11;

                    break;
            }
            try
            {
                for(int now = n + j; now > 10 || now <89 ; now += j) 
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
                    if (Board.board[now] == "0")
                    {
                        break;
                    }
                    if (Board.board[now]==c)
                    {
                        if(j<0)
                        {
                            for (now -= j; now < n; now -= j)
                            {
                                Board.board[now] = c;
                            }
                        }
                        if (j > 0)
                        {
                            for (now -= j; now > n; now -= j)
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
    public static int putcheck(string c)
    {
        int j = 0;
        int b = 0;
        for(int n = 11; n < 89; n++) { 
        for (int i = 0; i < 8; i++)
        {
            switch (i)
            {
                case 0:
                    j = -11;
                    break;
                case 1:
                    j = -10;
                    break;
                case 2:
                    j = -9;
                    break;
                case 3:
                    j = -1;
                    break;
                case 4:
                    j = 1;
                    break;
                case 5:
                    j = 9;
                    break;
                case 6:
                    j = 10;
                    break;
                case 7:
                    j = 11;

                    break;
            }
            try
            {
                for (int now = n + j; now > 10 || now < 89; now += j)
                {
                    if (Board.board[n] != " ")
                    {
                        break;
                    }
                    if (Board.board[n + j] == c)
                    {
                        break;
                    }
                    if (Board.board[now] == " ")
                    {
                        break;
                    }
                    if (Board.board[now] == c)
                    {
                        b = 1;
                        break;
                    }

                }
            }
            catch (IndexOutOfRangeException) { }

        }
        }
        return b;
    }

}