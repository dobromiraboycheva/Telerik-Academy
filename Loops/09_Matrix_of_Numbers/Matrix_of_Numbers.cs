using System;
//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

class Matrix_of_Numbers
{
    static void Main()
    {
        Console.Write("Enten number between 1 and 20\nn= ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 20)
        {
            Console.WriteLine("ERROR:0<n<21");
        }
        else
        {
            for (int row = 1; row <= n; row++)
            {
                for (int colom = 0; colom < n; colom++)
                {
                    Console.Write("{0,2}", colom + row);
                }
                Console.WriteLine();
            }
        }
    }
}
