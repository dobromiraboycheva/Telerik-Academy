using System;
//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

class Circle_Perimeter_and_Area
{
    static void Main()
    {
        Console.Write("Enter radius of cercle R=");
        double R = double.Parse(Console.ReadLine());
        Console.WriteLine("R={0:F2}\tP={1:F2}\tS={2:F2}\t", R, Math.PI * 2 * R, Math.PI * Math.Pow(R, 2));
    }
}
