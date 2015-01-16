using System;
using System.Numerics;
//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100)

class Catalan_Numbers
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 100)
        {
            Console.WriteLine("ERROR:0<n<100");
        }
        else
        {
            BigInteger fak2 = 1;
            BigInteger fak = 1;
            for (int i = n + 2; i <= 2 * n; i++)
            {
                fak2 *= i;
            }
            for (int j = 1; j <= n; j++)
            {
                fak *= j;
            }
            BigInteger C = (fak2 / fak);
            Console.WriteLine("(2*{0})!/(n+1)!*n!={1}", n, C);
        }
    }
}
