using System;
//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

class Odd_or_Even_Integers
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Odd? {0}",i % 2 != 0);
    }
}