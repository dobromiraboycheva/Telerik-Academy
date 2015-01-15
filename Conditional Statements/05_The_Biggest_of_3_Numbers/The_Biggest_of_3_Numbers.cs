using System;
//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three number

class The_Biggest_of_3_Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter Third number: ");
        double c = double.Parse(Console.ReadLine());
        // Console.WriteLine("The biggest number is: {0}",Math.Max(Math.Max(a,b),c));
        if (a >= b && a >= c)
        {
            Console.WriteLine("The biggest number is: {0}", a);
        }
        if (b >= a && b >= c)
        {
            Console.WriteLine("The biggest number is: {0}", b);
        }
        if (c >= a && c >= b)
        {
            Console.WriteLine("The biggest number is: {0}", c);
        }
    }
}
