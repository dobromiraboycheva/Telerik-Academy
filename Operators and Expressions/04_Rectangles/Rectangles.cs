using System;
//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Rectangles
{
    static void Main()
    {
        Console.Write("Hight of retangle: ");
        double hight = double.Parse(Console.ReadLine());
        Console.Write("Width of retangle: ");
        double width = double.Parse(Console.ReadLine());
        double Perimeter = 2 * hight + 2 * width;
        double area = hight * width;
        Console.WriteLine("Perimeter: {0}", Perimeter);
        Console.WriteLine("Area: {0}", area);
    }
}
