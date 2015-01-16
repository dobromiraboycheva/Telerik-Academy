using System;
using System.Numerics;
//Problem 18.* Trailing Zeroes in N!

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

class Trailing_Zeroes_in_N_factoriel
{
    static void Main()
    {
        Console.Write("Enter N= ");
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        int j = 0;
        if (N > 100000 || N < 1)
        {
            Console.WriteLine("ERROR:1<N<100000");
        }
        else
        {
            BigInteger faktoriel = 1;
            for (int i = 1; i <= N; i++)
            {
                faktoriel *= i;
            }
            Console.WriteLine("{0}!={1}", N, faktoriel);
            while (faktoriel % 10 == 0)
            {
                j++;
                faktoriel /= 10;
            }
            Console.WriteLine("{0} zeros at the end of the number", j);
        }
    }
}