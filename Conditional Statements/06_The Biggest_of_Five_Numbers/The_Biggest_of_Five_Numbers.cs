using System;
//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

class The_Biggest_of_Five_Numbers
{
    static void Main()
    {
        Console.Write("Enter First number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter Second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter Third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter Fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter Fifth number: ");
        double e = double.Parse(Console.ReadLine());
        //if (a >= b && a >= c && a >= d && a >= e)
        //{
        //    Console.WriteLine("The biggest number is: {0}", a);
        //}
        //if (b >= a && b >= c && b >= d && b >= e)
        //{
        //    Console.WriteLine("The biggest number is: {0}", b);
        //}
        //if (c >= a && c >= b && c >= d && c >= e)
        //{
        //    Console.WriteLine("The biggest number is: {0}", c);
        //}
        //if (d >= a && d >= b && d >= c && d >= e)
        //{
        //    Console.WriteLine("The biggest number is: {0}", d);
        //}
        //if (e >= a && e >= b && e >= c && e >= d)
        //{
        //    Console.WriteLine("The biggest number is: {0}", e);
        //}
        double max = a;
        if (a <= b)
        {
            max = b;
        }
        if (max <= c)
        {
            max = c;
        }
        if (max <= d)
        {
            max = d;
        }
        if (max <= e)
        {
            max = e;
        }
        Console.WriteLine("The biggest number is: {0}", max);
        // Console.WriteLine("The biggest number is: {0}",Math.Max(Math.Max(Math.Max(Math.Max(a,b),c),d,)e);
    }
}