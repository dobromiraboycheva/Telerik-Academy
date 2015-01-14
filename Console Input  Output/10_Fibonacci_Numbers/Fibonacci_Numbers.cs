using System;
//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

class Fibonacci_Numbers
{
    static void Main()
    {
        Console.Write("Enten which will be the last position of Fibonacci sequence=");
        int n = int.Parse(Console.ReadLine());
        uint num1 = 0;
        uint num2 = 1;
        uint sum = 0;
        Console.Write(num1 + " " + num2 + " ");
        for (int i = 0; i < n - 2; i++)
        {
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            Console.Write(sum + " ");
        }
        Console.WriteLine();
    }
}
