using System;
//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class Hexadecimal_to_Decimal_Number
{
    static void Main()
    {
        Console.Write("Enter your Hexadecimal number: ");
        string Hex = Console.ReadLine();
        long decim = 0;
        int pow = 1;
        for (int i = Hex.Length - 1; i >= 0; i--)
        {
            int num;
            switch (Hex[i])
            {
                case 'A':
                    num = 10;
                    break;
                case 'B':
                    num = 11;
                    break;
                case 'C':
                    num = 12;
                    break;
                case 'D':
                    num = 13;
                    break;
                case 'E':
                    num = 14;
                    break;
                case 'F':
                    num = 15;
                    break;
                default:
                    num = (int)Hex[i] - 48;
                    break;
            }
            decim += num * pow;
            pow *= 16;
        }
        Console.WriteLine(decim);
    }
}