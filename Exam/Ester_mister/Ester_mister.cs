using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ester_mister
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        for (int row = 0; row <2*N; row++)
        {
            for (int j = 0; j < (3 * N + 1); j++)
            {
                if (row == N)
                {

                    if (j % 2 != 0 && j >= 0 && j <= N * 3)
                    {
                        Console.Write(".");
                    }
                    else if (j % 2 == 0 && j > 1 && j < N * 3 - 1)
                    {
                        Console.Write("#");
                    }
                    if (j == 1 || j == 3 * N - 2)
                    {
                        Console.Write("*");
                    }
                }
                if (row == N - 1)
                {
                    if (j % 2 == 0 && j >= 0 && j <= N * 3)
                    {
                        Console.Write(".");
                    }
                    else if (j % 2 != 0 && j > 1 && j < N * 3 - 1)
                    {
                        Console.Write("#");
                    }
                    if (j == 1 || j == 3 * N - 2)
                    {
                        Console.Write("*");
                    }
                }
                if (row >= (N - N / 2) && row < (N + N / 2) && row != N && row != N - 1)
                {
                    if (j == 1 || j == 3 * N - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                if (row == 0 || row == 2 * N - 1)
                {
                    if (j > (2 * N) / 2 && j <= (4 * N - 1) / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                if (row > 0 && row <N / 2)
                {
                    if (j == N - 2 * row + 1 || j == 3 * N - (N - 2 * row + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                if (row < 2 * N-1 && row >= 3 * N / 2)
                {
                    if (j ==  2 * row -3*N +3|| j == 6 * N - (2 * row + 3))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    } 
                }
            }
            Console.WriteLine();
        }
    }
}
