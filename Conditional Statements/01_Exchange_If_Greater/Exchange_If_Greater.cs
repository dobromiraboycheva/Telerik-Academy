﻿using System;
//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class Exchange_If_Greater
{
    static void Main()
    {
        Console.Write("Enter a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(b + " " + a);
        }
        if (a <= b)
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
