using System;
//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

class Quadratic_Equation
{
    static void Main()
    {
        Console.WriteLine("ax^2+bx+c=0");
        Console.Write("Enter a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c=");
        double c = double.Parse(Console.ReadLine());

        if (Math.Pow(b, 2) - 4 * a * c < 0)
        {
            Console.WriteLine("The equation haven't real answars");
        }
        else
        {
            if (Math.Pow(b, 2) - 4 * a * c == 0)
            {
                Console.WriteLine("{1}X^2+{2}X+{3}=0\nX1=X2={0:F2}", -b / (2 * a), a, b, c);
            }
            else
            {
                Console.WriteLine("{2}X^2+{3}X+{4}=0\nX1={0}\nX2={1}", (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a), (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a), a, b, c);
            }
        }
    }
}
