using System;
//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

class Min_Max_Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        Console.Write("Enter how many number you will enter? n= ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("ERROR");
        }
        else
        {

            int number = int.Parse(Console.ReadLine());
            int min = number;
            int max = number;
            double sum = number;
            for (int i = 1; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
                sum += number;
            }
            Console.WriteLine("min={0}", min);
            Console.WriteLine("max={0}", max);
            Console.WriteLine("sum={0}", sum);
            double avr = sum / n;
            Console.WriteLine("avr={0:F2}", avr);
        }
    }
}