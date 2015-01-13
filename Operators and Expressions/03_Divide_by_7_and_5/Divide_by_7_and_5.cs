using System;
//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

    class Divide_by_7_and_5
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int i = int.Parse(Console.ReadLine());
            if (i % 5 == 0 && i % 7 == 0)
                Console.WriteLine("Your number is divide by 7 and 5 at the same time");
            else
                Console.WriteLine("Your number is NOT divide by 7 and 5 at the sametime");
        }
    }
