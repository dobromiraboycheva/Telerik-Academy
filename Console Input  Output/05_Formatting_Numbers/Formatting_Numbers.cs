using System;
//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

class Formatting_Numbers
{
    static void Main()
    {
        Console.Write("Enter integer a=");
        int a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            Console.Write("a must be in interval (0;500) Please try againt! a=");
            a = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter float b=");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter float c=");
        float c = float.Parse(Console.ReadLine());
        string binarry = Convert.ToString(a, 2);
        Console.WriteLine("|{0,-10:X}|{3}|{1,10:F2}|{2,-10:F3}|", a, b, c, binarry.PadLeft(10, '0'));
    }
}

