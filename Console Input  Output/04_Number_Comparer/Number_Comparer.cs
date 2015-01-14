using System;
//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

class Number_Comparer
{
    static void Main()
    {
        Console.Write("Enter first number:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        double b = double.Parse(Console.ReadLine());
        double c = Math.Max(a, b);
        Console.WriteLine("Greater is: {0}", c);
    }
}
