using System;
//Problem 9. Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
class PrintSequence
{
    static void Main()
    {
        int NumberToPrint;
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)

                NumberToPrint = i;
            else
                NumberToPrint = i * (-1);
            Console.Write(NumberToPrint);
            Console.Write(", ");
        }
    }
}

