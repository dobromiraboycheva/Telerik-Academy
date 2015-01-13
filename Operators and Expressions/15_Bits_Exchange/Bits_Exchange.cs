using System;
//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class Bits_Exchange
{
    static void Main()
    {
        Console.Write("How many numers do you want to check? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter your intiger number: ");
            uint number = uint.Parse(Console.ReadLine());
            uint number2 = number;
            uint mask = 1;
            uint bit1;
            uint bit2;
            byte k = 3;
            byte p = 24;
            for (int j = 1; j <= 3; j++, k++, p++)
            {
                mask = mask << k;
                bit1 = (mask & number) >> k;
                mask = mask >> k;
                mask = mask << p;
                bit2 = (mask & number) >> p;
                mask >>= p;
                if (bit1 != bit2)
                {
                    if (bit1 == 1)
                    {
                        uint number1 = number | (mask << p);
                        number = number1 ^ (mask << k);
                    }
                    else
                    {
                        uint number1 = number ^ (mask << p);
                        number = number1 | (mask << k);

                    }
                }
            }
            Console.WriteLine("Your number is {2} in binar system {1}\nYour result after exchange is {0} in binar system is {1} ", number, Convert.ToString(number, 2), number2, Convert.ToString(number2, 2));

        }
    }
}
