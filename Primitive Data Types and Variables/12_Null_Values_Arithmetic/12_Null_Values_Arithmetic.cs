using System;
//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class Null_Values_Arithmetic
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("i= {0} \nd= {1}", i, d);
        i = 5;
        Console.WriteLine("i={0}", i.GetValueOrDefault());
        d = 10;
        Console.WriteLine("d={0}", d.GetValueOrDefault());
    }
}

