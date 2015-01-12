using System;
//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

class Comparing_Floats
{
    static void Main()
    {

        double constant = 0.000001;
        Console.WriteLine("Enter number floating-point numbers a and b:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        if (Math.Abs(a - b) < constant)
            Console.WriteLine("a = b \nTrue");
        else
            Console.WriteLine("a=!b \nFalse");
       
    }
}

