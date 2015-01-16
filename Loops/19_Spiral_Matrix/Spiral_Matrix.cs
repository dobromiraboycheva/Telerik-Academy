using System;
//Problem 19.** Spiral Matrix

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

class Spiral_Matrix
{
    static void Main()
    {
        Console.Write("Enter N= ");
        int N = int.Parse(Console.ReadLine());
        if (N > 20 || N < 1)
        {
            Console.WriteLine("ERROR:0 < N < 21");
        }
        else
        {
            Console.Clear();
            int[,] matrix = new int[N, N];
            int row = 0;
            int col = 0;
            int value = 1;
            while (value <= N * N)
            {
                while (col < matrix.GetLength(0) && matrix[row, col] == 0)
                {
                    matrix[row, col++] = value;
                    value++;
                }
                col--;
                row++;
                while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                {
                    matrix[row++, col] = value;
                    value++;
                }
                col--;
                row--;
                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col--] = value;
                    value++;
                }
                col++;
                row--;
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row--, col] = value;
                    value++;
                }
                col++;
                row++;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(j * 5, i * 2);
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}