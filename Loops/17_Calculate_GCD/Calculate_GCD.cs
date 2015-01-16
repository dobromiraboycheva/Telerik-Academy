using System;
//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

class Calculate_GCD
{
    static void Main()
    {
        Console.Write("Enter a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        int b = int.Parse(Console.ReadLine());
        int GCD = 1;
        while (GCD != 0)
        {
            GCD = a % b;
            a = b;
            b = GCD;
        }
        Console.WriteLine(Math.Abs(a));
    }
}