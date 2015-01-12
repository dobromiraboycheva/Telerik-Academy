using System;
//Problem 7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

class Quotes_in_Strings
{
    static void Main()
    {
        string first = @"The ""use"" of quotations causes difficulties.";
        string second = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("First: "+first);
        Console.WriteLine("Second: "+second);
    }
}