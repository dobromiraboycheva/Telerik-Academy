using System;
//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class Sum_of_5_Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers in one line with space between them:");
        string numbers = Console.ReadLine();
        string[] splitsum = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double sum = double.Parse(splitsum[0]) + double.Parse(splitsum[1]) + double.Parse(splitsum[2]) + double.Parse(splitsum[3]) + double.Parse(splitsum[4]);
        Console.WriteLine("The sum is:{0:F3}", sum);
    }
}

