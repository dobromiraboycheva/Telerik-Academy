using System;
//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

class Check_Bit_at_Given_Position
{
    static void Main()
    {
        Console.Write("How many numers do you want to check? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter your intiger number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter which binar position you want to know: ");
            int p = int.Parse(Console.ReadLine());
            int movebit = number >> p;
            int bit = movebit & 1;
            bool answar = bit == 1 ? true : false;
            Console.WriteLine("The #{0} bit of {2} is 1 : {1}", p, answar, Convert.ToString(number, 2));
        }
    }
}
