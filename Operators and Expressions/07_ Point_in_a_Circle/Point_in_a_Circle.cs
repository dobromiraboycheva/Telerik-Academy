using System;
//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

class Point_in_a_Circle
{
    static void Main()
    {
        Console.Write("Enter radius of circle which is with center (0,0):");
        double r = double.Parse(Console.ReadLine());
        Console.Write("How many point you want to check? ");
        int NumberOfPints = int.Parse(Console.ReadLine());
        for (int j = 0; j < NumberOfPints; j++)
        {
            Console.Write("Enter x ordinat of your point:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y ordinat of your point: ");
            double y = double.Parse(Console.ReadLine());
            if (x * x + y * y <= r * r)
                Console.WriteLine("Your point is IN the circle\n");
            else
                Console.WriteLine("Your point is OUT of the circle\n");
        }
    }
}

