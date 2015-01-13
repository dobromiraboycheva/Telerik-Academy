using System;
//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

class Bitwise_Extract_Bit_3
{
    static void Main()
    {
        Console.Write("How many numers do you want to check? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter your real number: ");
            int number = int.Parse(Console.ReadLine());
            int movebit = number >> 3;
            int bit = movebit & 1;
            Console.WriteLine("The #3 bit of {0} is : {1}", Convert.ToString(number, 2), bit);
        }
    }
}