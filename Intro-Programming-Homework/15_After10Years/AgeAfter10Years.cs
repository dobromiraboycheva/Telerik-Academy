using System;
//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birthday in format DD.MM.YYYY ");
        DateTime BirthDay=DateTime.Parse(Console.ReadLine());
        int age = DateTime.Now.Year - BirthDay.Year;
        if (DateTime.Now.Month < BirthDay.Month)
            age = age - 1;
        if (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day)
            age = age - 1;
        if (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day == BirthDay.Day)
            Console.WriteLine("Today you have a birthday! Congratulations!");
        int age10 = age + 10;
        Console.WriteLine("Now you are {0} years old. After 10 years you will be {1} years old.",age,age10);

    }
}
