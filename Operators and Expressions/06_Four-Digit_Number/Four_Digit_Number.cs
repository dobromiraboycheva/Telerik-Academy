using System;
//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

class Four_Digit_Number
{
    static void Main()
    {
        Console.Write("Enter four digital number:");
        int i = int.Parse(Console.ReadLine());
        int num1 = i / 1000;
        int num2 = (i / 100) % 10;
        int num3 = (i / 10) % 10;
        int num4 = i % 10;
        Console.WriteLine("Sum of all numbers={0}", num1 + num2 + num3 + num4);
        Console.WriteLine("Miracle digital number is: {0}{1}{2}{3}", num4, num3, num2, num1);
        Console.WriteLine("Last digit in the first position is: {0}{1}{2}{3}", num4, num1, num2, num3);
        Console.WriteLine("Second and the third digits is: {0}{1}{2}{3}", num3, num4, num1, num2);
    }
}
