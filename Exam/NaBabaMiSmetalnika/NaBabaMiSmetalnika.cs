using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NaBabaMiSmetalnika
{
    static int n = int.Parse(Console.ReadLine());
    static int[,] matrix = new int[8, n];
    static void Main()
    {
        Input();
        Command();
        Result();

    }
    static void Input()
    {
        for (int row = 0; row < 8; row++)
        {
            int currentLine = int.Parse(Console.ReadLine());
            for (int col = 0; col < n; col++)
            {
                matrix[row, n - 1 - col] = (currentLine >> col) & 1;
            }
        }
    }
    static void Command()
    {
        string cmd = Console.ReadLine();
        while (cmd != "stop")
        {
            int onceCount = 0;
            switch (cmd)
            {
                case "reset":
                    {
                        for (int row = 0; row < 8; row++)
                        {
                            onceCount = 0;
                            for (int col = 0; col < n; col++)
                            {
                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    onceCount++;
                                }
                            }
                            for (int col = 0; col<onceCount;col++)
                            {
                                matrix[row, col] = 1;
                            }

                        }
                    }
                    break;
                case "left":
                    {
                        int rows = int.Parse(Console.ReadLine());
                        int cols = int.Parse(Console.ReadLine());
                        if (cols < 0)
                        {
                            cols = 0;
                        }
                        if (cols > n-1)
                        {
                            cols = n - 1;
                        }
                        onceCount = 0;
                        for (int col = 0; col <=cols; col++)
                        {
                            if (matrix[rows, col] == 1)
                            {
                                matrix[rows, col] = 0;
                                onceCount++;
                            }
                        }
                        for (int col = 0; col<onceCount;col++)
                        {
                            matrix[rows, col] = 1;
                        }
                    }
                    break;
                case "right":
                    {
                        int rows = int.Parse(Console.ReadLine());
                        int cols = int.Parse(Console.ReadLine());
                        if (cols < 0)
                        {
                            cols = 0;
                        }
                        if (cols > n-1)
                        {
                            cols = n - 1;
                        }
                        onceCount = 0;
                        for (int col = cols; col < n; col++)
                        {
                            if (matrix[rows, col] == 1)
                            {
                                matrix[rows, col] = 0;
                                onceCount++;
                            }
                        }
                        for (int col = n - 1; onceCount > 0; onceCount--, col--)
                        {
                            matrix[rows, col] = 1;

                        }
                    }
                    break;
            }
            cmd = Console.ReadLine();
        }
    }
    static void Result()
    {
        long result = 0;
        for (int row = 0; row < 8; row++)
        {


            string str = "";
            for (int col = 0; col < n; col++)
            {
                str += matrix[row, col];
            }
            long number = Convert.ToInt64(str, 2);
            result += number;
        }

        int zeroColumnCounter = 0;

        for (int col = n - 1; col >= 0; col--)
        {
            int zeroesCounter = 0;
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 0)
                {
                    zeroesCounter++;
                }
            }
            if (zeroesCounter == 8)
            {
                zeroColumnCounter++;
            }
        }
        Console.WriteLine(result * zeroColumnCounter);
    }
    static void Output()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

