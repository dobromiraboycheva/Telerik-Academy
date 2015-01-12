using System;
using System.Text;
//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©
class Isosceles_Triangle
{
    static void Main()
    {
         char copyright='\u00a9';
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("   {0}", copyright);
        Console.WriteLine();
        Console.WriteLine("  {0} {0} ", copyright);
        Console.WriteLine();
        Console.WriteLine(" {0}   {0} ", copyright);
        Console.WriteLine();
        Console.WriteLine("{0} {0} {0} {0}", copyright);
    }
}

