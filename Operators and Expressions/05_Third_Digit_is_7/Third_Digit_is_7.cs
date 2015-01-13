using System;
//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

class Third_Digit_is_7
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int i = int.Parse(Console.ReadLine());
        int hundreds = (i / 100) % 10;
        Console.WriteLine("Your hundreds are 7? {0}", hundreds == 7);
    }
}

