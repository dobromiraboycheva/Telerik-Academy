using System;
//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

class Extract_Bit_from_Integer
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
            Console.WriteLine("The #{0} bit of {2} is : {1}",p, bit, Convert.ToString(number, 2));
        }
    }
}