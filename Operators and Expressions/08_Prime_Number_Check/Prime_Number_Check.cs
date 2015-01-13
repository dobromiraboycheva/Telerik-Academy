using System;

class Prime_Number_Check
{
    static void Main()
    {
        Console.Write("Enter your number form 2 to 100: ");
        int i = int.Parse(Console.ReadLine());
        if (i < 2 || i > 100)
        {
            Console.WriteLine("ERROR:Your number is not in the interval");
        }
        else
        {
            bool Prime=true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
                if (i % j == 0)
                {
                    Prime=false;
                }
            if (Prime)
            {
                Console.WriteLine("The number {0} is prime.",i);
            }
            else
            {
                Console.WriteLine("The number {0} is NOT prime.",i);
            }
        }

    }
}

