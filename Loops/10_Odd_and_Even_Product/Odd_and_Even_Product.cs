using System;
//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

class Odd_and_Even_Product
{
    static void Main()
    {
        int odd = 1;
        int even = 1;
        Console.Write("Enter your numbers with ' ' between them: ");
        string ReadNumbers = Console.ReadLine();
        string[] Numbers = ReadNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < Numbers.Length; i++)
        {
            int number = int.Parse(Numbers[i]);
            if (i % 2 == 0)
            {
                odd *= number;
            }
            else
            {
                even *= number;
            }
        }
        if (odd == even)
        {
            Console.WriteLine("YES");
            Console.WriteLine("Product={0}", odd);
        }
        else
        {
            Console.WriteLine("NO");
            Console.WriteLine("odd_product={0}", odd);
            Console.WriteLine("even_product={0}", even);
        }
    }
}