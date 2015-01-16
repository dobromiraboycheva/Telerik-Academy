using System;
using System.Numerics;
//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is
//calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

class Calculate_Combinations
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k= ");
        int k = int.Parse(Console.ReadLine());
        if (n > 100 || n < 1 || k > 100 || k < 1 || n < k)
        {
            Console.WriteLine("ERROR:1<K<N<100");
        }
        else
        {
            BigInteger faktorielN = 1;
            BigInteger faktorielK = 1;
            BigInteger faktoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                faktorielN *= i;
                if (i <= k)
                {
                    faktorielK *= i;
                }
            }

            for (int j = 1; j <= (n - k); j++)
            {
                faktoriel *= j;
            }
            BigInteger NumComb = faktorielN / (faktorielK * faktoriel);
            Console.WriteLine("{0}!/({1}!*({0}-{1})!)={2}", n, k, NumComb);
        }
    }
}