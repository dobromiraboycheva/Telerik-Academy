using System;
//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

class Bonus_Score
{
    static void Main()
    {
        Console.Write("Enter your score between 1 and 9: ");
        int score = int.Parse(Console.ReadLine());
        if (score >= 1 && score <= 3)
        {
            Console.WriteLine("Your bonus score is {0}", score * 10);
        }

        if (score >= 4 && score <= 6)
        {
            Console.WriteLine("Your bonus score is {0}", score * 100);
        }

        if (score >= 7 && score <= 9)
        {
            Console.WriteLine("Your bonus score is {0}", score * 1000);

        }
        if (score <= 0 || score > 9)
        {
            Console.WriteLine("Invalide score!");
        }
    }
}
