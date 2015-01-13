using System;
//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class Gravitation_on_the_Moon
{
    static void Main()
    {
        Console.Write("Enter your waight: ");
        double Waight_Earth = double.Parse(Console.ReadLine());
        double Waight_Moon = 0.17 * Waight_Earth;
        Console.WriteLine("Your waight on the Moon will be: {0}", Waight_Moon);
    }
}