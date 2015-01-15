using System;
//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

class Beer_Time
{
    static void Main()
    {
        DateTime timeBeer = new DateTime();
        Console.Write("Enter time in format hh:mm tt ");
        bool Valid = DateTime.TryParse(Console.ReadLine(), out timeBeer);
        if (Valid)
        {

            if ((timeBeer.Hour >= 13 && timeBeer.Hour <= 24) || (timeBeer.Hour >= 0 && timeBeer.Hour < 3))
            {
                Console.WriteLine("Beer Time!");
            }
            else
            {
                Console.WriteLine("None Beer Time :(");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}
