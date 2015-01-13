using System;
//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

class Modify_Bit_at_Given_Position
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
            Console.Write("Enter value at the position in binar system 0 or 1: ");
            int v = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                int mask = 1 << p;
                int result = number | mask;
                Console.WriteLine("The number {0} in binar system {1} with change posistion {2} in {3} is in binar system {4} and the numbar is {5}", number, Convert.ToString(number, 2), p, v, Convert.ToString(result, 2), result);
            }
            else
                if (v == 0)
                {
                    int mask = ~(1 << p);
                    int result = number & mask;
                    Console.WriteLine("The number {0} in binar system {1} with change posistion {2} in {3} is in binar system {4} and the numbar is {5}", number, Convert.ToString(number, 2), p, v, Convert.ToString(result, 2), result);
                }
                else
                    Console.WriteLine("ERROR: Incorect value of bit");

        }
    }
}