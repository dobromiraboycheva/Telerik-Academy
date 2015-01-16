using System;
using System.Numerics;
//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

class Calculate_N_K
{
    static void Main()
    {
        Console.Write("Enter N= ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K= ");
        int K = int.Parse(Console.ReadLine());
        if (N > 100 || N < 1 || K > 100 || K < 1 || N < K)
        {
            Console.WriteLine("ERROR:1<K<N<100");
        }
        else
        {
            BigInteger faktoriel = 1;
            for (int i = N; i > K; i--)
            {
                faktoriel *= i;
            }
            Console.WriteLine("{0}!/{1}!={2}", N, K, faktoriel);
        }
    }
}
