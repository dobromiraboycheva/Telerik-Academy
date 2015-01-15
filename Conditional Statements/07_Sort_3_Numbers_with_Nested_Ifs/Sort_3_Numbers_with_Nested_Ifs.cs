using System;
//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

class Sort_3_Numbers_with_Nested_Ifs
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter Third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a >= c)
        {
            if (b >= c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
        else
        {
            if (a >= b)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}
