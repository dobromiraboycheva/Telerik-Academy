using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GameOfPage
{
    static void Main()
    {
        const int n = 16;
        int[,] matrix = new int[n, n];
        List<string> answar = new List<string>();
        int counterCookies = 0;
       
        //Input
        for (int row = 0; row < n; row++)
        {
            string rows = Console.ReadLine();
            for (int col = 0; col < n; col++)
            {

                matrix[row, col] = int.Parse(rows[col].ToString());
            }
        }
        string text = Console.ReadLine();
        while (text != "paypal")
        { 
            int countCookiesPieces = 0;
            //WHAT IS
            if (text == "what is")
            {
                int firstLineRow = int.Parse(Console.ReadLine());
                int secondLineCol = int.Parse(Console.ReadLine());
                if (matrix[firstLineRow, secondLineCol] == 0)
                {
                    answar.Add("smile");
                }
                else if (firstLineRow > 0 && firstLineRow < 15 && secondLineCol > 0 && secondLineCol < 15)
                {
                    for (int row = firstLineRow - 1; row <= firstLineRow + 1; row++)
                    {
                        for (int col = secondLineCol - 1; col <= secondLineCol + 1; col++)
                        {
                            if (matrix[row, col] == 1)
                            {
                                countCookiesPieces++;
                            }
                        }
                    }
                    if (countCookiesPieces>1 && countCookiesPieces < 9)
                    {
                       answar.Add("broken cookie");
                    }
                    if(countCookiesPieces==1)
                    {
                        answar.Add("cookie crumb");
                    }
                    if(countCookiesPieces==9) 
                    {
                        answar.Add("cookie");
                    }
                }
                else if (firstLineRow == 0 && secondLineCol > 0 && secondLineCol < 15 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow, secondLineCol - 1] == 0 && matrix[firstLineRow, secondLineCol + 1] == 0 && matrix[firstLineRow + 1, secondLineCol] == 0 && matrix[firstLineRow + 1, secondLineCol - 1] == 0 && matrix[firstLineRow + 1, secondLineCol + 1] == 0)
                    {
                        answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow, secondLineCol - 1] == 1 || matrix[firstLineRow, secondLineCol + 1] == 1 || matrix[firstLineRow + 1, secondLineCol] == 1 || matrix[firstLineRow + 1, secondLineCol - 1] == 1 || matrix[firstLineRow + 1, secondLineCol + 1] == 1)
                    {
                        answar.Add("broken cookie");
                    }
                }
                else if (firstLineRow == 15 && secondLineCol > 0 && secondLineCol < 15 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow - 1, secondLineCol] == 0 && matrix[firstLineRow - 1, secondLineCol - 1] == 0 && matrix[firstLineRow - 1, secondLineCol + 1] == 0 && matrix[firstLineRow, secondLineCol - 1] == 0)
                    {
                       answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow - 1, secondLineCol] == 1 || matrix[firstLineRow - 1, secondLineCol - 1] == 1 || matrix[firstLineRow - 1, secondLineCol + 1] == 1 || matrix[firstLineRow, secondLineCol - 1] == 1 || matrix[firstLineRow, secondLineCol + 1] == 1)
                    {
                        answar.Add("broken cookie");
                    }
                }
                else if (firstLineRow > 0 && firstLineRow < 15 && secondLineCol == 0 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow - 1, secondLineCol] == 0 && matrix[firstLineRow - 1, secondLineCol + 1] == 0 && matrix[firstLineRow, secondLineCol + 1] == 0 && matrix[firstLineRow + 1, secondLineCol] == 0 && matrix[firstLineRow + 1, secondLineCol + 1] == 0)
                    {
                        answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow - 1, secondLineCol] == 1 || matrix[firstLineRow - 1, secondLineCol + 1] == 1 || matrix[firstLineRow, secondLineCol + 1] == 1 || matrix[firstLineRow + 1, secondLineCol] == 1 || matrix[firstLineRow + 1, secondLineCol + 1] == 1)
                    {
                        answar.Add("broken cookie");
                    }
                }
                else if (firstLineRow > 0 && firstLineRow < 15 && secondLineCol == 15 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow - 1, secondLineCol] == 0 && matrix[firstLineRow - 1, secondLineCol - 1] == 0 && matrix[firstLineRow - 1, secondLineCol + 1] == 0 && matrix[firstLineRow, secondLineCol - 1] == 0 &&
                            matrix[firstLineRow, secondLineCol + 1] == 0 && matrix[firstLineRow + 1, secondLineCol] == 0 && matrix[firstLineRow + 1, secondLineCol - 1] == 0 && matrix[firstLineRow + 1, secondLineCol + 1] == 0)
                    {
                        answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow - 1, secondLineCol] == 1 || matrix[firstLineRow - 1, secondLineCol - 1] == 1 || matrix[firstLineRow, secondLineCol - 1] == 1 || matrix[firstLineRow + 1, secondLineCol] == 1 || matrix[firstLineRow + 1, secondLineCol - 1] == 1)
                    {
                        answar.Add("broken cookie");
                    }
                }
                else if (firstLineRow == 0 && secondLineCol == 0 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow, secondLineCol + 1] == 0 && matrix[firstLineRow + 1, secondLineCol] == 0 && matrix[firstLineRow + 1, secondLineCol + 1] == 0)
                    {
                        answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow, secondLineCol + 1] == 1 || matrix[firstLineRow + 1, secondLineCol] == 1 || matrix[firstLineRow + 1, secondLineCol + 1] == 1)
                    {
                        answar.Add("broken cookie");
                    }
                }
                else if (firstLineRow == 0 && secondLineCol == 15 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow, secondLineCol - 1] == 0 && matrix[firstLineRow + 1, secondLineCol] == 0 && matrix[firstLineRow + 1, secondLineCol - 1] == 0)
                    {
                        answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow, secondLineCol - 1] == 1 || matrix[firstLineRow + 1, secondLineCol] == 1 || matrix[firstLineRow + 1, secondLineCol - 1] == 1)
                    {
                        answar.Add("broken cookie");
                    }
                }
                else if (firstLineRow == 15 && secondLineCol == 0 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow, secondLineCol + 1] == 0 && matrix[firstLineRow - 1, secondLineCol] == 0 && matrix[firstLineRow - 1, secondLineCol + 1] == 0)
                    {
                        answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow, secondLineCol + 1] == 1 || matrix[firstLineRow - 1, secondLineCol] == 1 || matrix[firstLineRow - 1, secondLineCol + 1] == 1)
                    {
                       answar.Add("broken cookie");
                    }
                }
                else if (firstLineRow == 15 && secondLineCol == 15 && matrix[firstLineRow, secondLineCol] == 1)
                {
                    if (matrix[firstLineRow, secondLineCol - 1] == 0 && matrix[firstLineRow - 1, secondLineCol] == 0 && matrix[firstLineRow - 1, secondLineCol - 1] == 0)
                    {
                        answar.Add("cookie crumb");
                    }
                    if (matrix[firstLineRow, secondLineCol - 1] == 1 || matrix[firstLineRow - 1, secondLineCol] == 1 || matrix[firstLineRow - 1, secondLineCol - 1] == 1)
                    {
                        answar.Add("broken cookie");
                    }
                }
            }
            //BUY
            else if (text == "buy")
            {
                int firstLineRow = int.Parse(Console.ReadLine());
                int secondLineCol = int.Parse(Console.ReadLine());
                if (matrix[firstLineRow, secondLineCol] == 0)
                {
                    answar.Add("smile");
                }
                else
                {
                    if (firstLineRow == 0 || firstLineRow == 15 || secondLineCol == 0 || secondLineCol == 15)
                    {
                        answar.Add("page");
                    }
                    else
                    {
                        for (int row = firstLineRow - 1; row <= firstLineRow + 1; row++)
                        {
                            for (int col = secondLineCol - 1; col <= secondLineCol + 1; col++)
                            {
                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    countCookiesPieces++;
                                }
                            }
                        }
                        if (countCookiesPieces == 9)
                        {
                            counterCookies++;
                        }
                        if (countCookiesPieces < 9)
                        {
                            answar.Add("page");
                        }
                    }
                }
            }
            text = Console.ReadLine();
        }
        for (int i = 0; i < answar.Count; i++)
			{
			 Console.WriteLine(answar[i]);
			}
        Console.WriteLine("{0:0.00}", counterCookies * 1.79);
    }
}

