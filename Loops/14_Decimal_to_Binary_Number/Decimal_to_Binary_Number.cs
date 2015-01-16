using System;
//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

class Decimal_to_Binary_Number
{
    static void Main()
    {
        Console.Write("Enter your decimal number: ");
        long decim = long.Parse(Console.ReadLine());
        long binar = 0;
        string binarry = string.Empty;
        while (decim > 0)
        {
            binar = decim % 2;
            decim /= 2;
            binarry = binar.ToString() + binarry;
        }
        Console.WriteLine(binarry);
    }
}