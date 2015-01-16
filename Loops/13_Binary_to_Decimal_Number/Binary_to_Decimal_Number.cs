using System;
//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class Binary_to_Decimal_Number
{
    static void Main()
    {
        Console.Write("Enter your binarry number: ");
        string binar = Console.ReadLine();
        long decim = 0;
        for (int i = 0; i < binar.Length; i++)
        {
            if (binar[binar.Length - i - 1] == '0')
            {
                continue;
            }
            decim += (long)Math.Pow(2, i);
        }
        Console.WriteLine(binar + "=" + decim);
    }
}
