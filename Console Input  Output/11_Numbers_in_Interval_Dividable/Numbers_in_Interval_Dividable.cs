using System;
//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

class Numbers_in_Interval_Dividable
{
    static void Main()
    {
        Console.Write("Enter First number:");
        uint First = uint.Parse(Console.ReadLine());
        Console.Write("Enter Second number:");
        uint Second = uint.Parse(Console.ReadLine());
        uint check = First;
        uint Sum = 0;
        var Fold = new System.Collections.Generic.List<uint>();
        if (First > Second)
        {
            First = Second;
            Second = check;
        }
        for (uint i = First; i <= Second; i++)
            if (i % 5 == 0)
            {
                Sum++;
                Fold.Add(i);
            }
        Console.WriteLine("Between First and Second number that you enter have {0} numbers fold to 5 and they are {1} ", Sum, string.Join(", ", Fold));
    }
}
