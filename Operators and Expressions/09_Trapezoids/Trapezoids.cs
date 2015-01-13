using System;
//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    static void Main()
    {
        Console.Write("How many trapezoid areas do you want to calculate? ");
        int NumberOfTrazoids = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberOfTrazoids; i++)
        {
            Console.Write("Bace a=");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Bace b=");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Height h=");
            float h = float.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0 || h <= 0)
                Console.WriteLine("ERROR:Negative size");
            float Area = ((a + b) / 2) * h;
            Console.WriteLine("Trapezoid with Bace a={0} and Bace b={1}, Height h={2} \nIs with Area={3}", a, b, h, Area);
        }
    }
}

