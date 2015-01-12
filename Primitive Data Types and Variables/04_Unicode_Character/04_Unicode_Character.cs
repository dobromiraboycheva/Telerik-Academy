using System;
//Problem 4. Unicode Character

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
class Unicode_Character
{
    static void Main()
    {
        char ch = '\u002a';
        Console.WriteLine("Symbol with Unicode 42 is {0}", ch);
    }
}
