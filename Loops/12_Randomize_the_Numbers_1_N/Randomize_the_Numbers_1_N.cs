using System;
using System.Linq;
using System.Collections;
//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

class Randomize_the_Numbers_1_N
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 1; i <= n; i++)
        {
            nums[i - 1] = i;
        }
            Random rnd = new Random();
            nums = nums.OrderBy(t => rnd.Next()).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }    
        Console.WriteLine();
    }
}