using System;
using System.Collections.Generic;
using System.Text;


public class Neurons
{
    public static void Main()
    {
        List<long> numbers = new List<long>();
        StringBuilder sequence = new StringBuilder();
        const int width = 32;
        int height = 0;
        while (true)
        {
            long n = long.Parse(Console.ReadLine());

            if (n == -1)
            {
                break;
            }
            numbers.Add(n);
            height++;
        }

        //creating the matrix and filling with "." for 0 and "B" (border) for 1

        string[,] matrix = new string[height, width];

        for (int row = 0; row < height; row++)
        {

            for (int col = width - 1; col >= 0; col--)
            {
                long digit = numbers[row] & (1 << col);
                sequence.Append(digit);

                if (digit == 0)
                {
                    matrix[row, (width - 1) - col] = ".";
                }
                else
                {
                    matrix[row, (width - 1) - col] = "B";
                }
            }
        }

        //matrix is filled uncomment next few lines to see how it looks

        //for (int row = 0; row < height; row++)
        //{
        //    for (int col = 0; col < width; col++)
        //    {
        //        Console.Write(matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}

        // filling left side with "B" until another "B" is reached
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == ".")
                {
                    matrix[row, col] = "B";
                }
                else
                {
                    break;
                }

            }
        }

        // filling right side from right ti left with "B" until another "B" is reached
        for (int row = 0; row < height; row++)
        {
            for (int col = width - 1; col >= 0; col--)
            {
                if (matrix[row, col] == ".")
                {
                    matrix[row, col] = "B";
                }
                else
                {
                    break;
                }

            }
        }

        //matrix is completed "B" and now "B" is for 0 and "." is for one
        // uncomment next few lines to see how it looks after

        //for (int row = 0; row < height; row++)
        //{
        //    for (int col = 0; col < width; col++)
        //    {
        //        Console.Write(matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}

        for (int row = 0; row < height; row++)
        {

            StringBuilder binNum = new StringBuilder();
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == "B")
                {
                    binNum.Append("0");
                }
                else
                {
                    binNum.Append("1");
                }
            }

            int digit = 0;
            int pow = 0;
            long result = 0;
            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                digit = binNum[i] - '0';
                result += (long)(digit * (Math.Pow(2, pow)));
                pow++;
            }
            Console.WriteLine(result);
        }
    }
}

