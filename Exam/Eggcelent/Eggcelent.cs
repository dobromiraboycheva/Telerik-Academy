using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int H = 2 * n;
        int W = 3 * n + 1;
        char[,] matrix = new char[H, W];
        //DOTS
        for (int row = 0; row < H; row++)
        {
            for (int col = 0; col < W; col++)
            {
                matrix[row, col] = '.';
            }
        }
        //Egg
        for (int row = 0; row < H; row++)
        {
            for (int col = 0; col < W; col++)
            {
                if ((row == 0 || row == H - 1) && col > n && col <= 2 * n - 1)
                {
                    matrix[row, col] = '*';
                }
                if (row == (n - 1))
                {
                    if (col > 1 && col < W - 1 && col % 2 == 0)
                    {
                        matrix[row, col] = '@';
                    }
                }
                if (row == n)
                {
                    if (col > 1 && col < W - 2 && col % 2 != 0)
                    {
                        matrix[row, col] = '@';
                    }
                }
                if (row >= n / 2 && row <= n + n / 2 - 1 && (col == 1 || col == W - 2))
                {
                    matrix[row, col] = '*';
                }
                if (row > 0 && row < n / 2  && (col == n + 1 - 2 * row || col == W - (n + 2 - 2 * row)))
                {
                    matrix[row, col] = '*';
                    
                }
                if (row > 0 && row < n / 2 && (col == n + 1 - 2 * row || col == W - (n +2 - 2 * row)))
                {
                    matrix[H - 1 - row, col] = '*';
                }
            }
        }
        //Output
        for (int row = 0; row < H; row++)
        {
            for (int col = 0; col < W; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

