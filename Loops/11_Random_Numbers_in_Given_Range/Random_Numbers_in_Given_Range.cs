using System;
//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].

class Random_Numbers_in_Given_Range
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min= ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max= ");
        int max = int.Parse(Console.ReadLine());
        if (max < min)
        {
            Console.WriteLine("ERROR: max < min");
        }
        else
        {
            Random randome = new Random();
            for (int i = 0; i < n; i++)
            {
                int num = randome.Next(min, max + 1);
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}