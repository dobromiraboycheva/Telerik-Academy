using System;
//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

class Sum_of_N_numbers
{
    static void Main()
    {
        Console.Write("Enten how many number will be sum\nn=");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = double.Parse(Console.ReadLine());
            sum = sum + i;
        }
        Console.WriteLine("Sum ={0}",sum);
    }
}
