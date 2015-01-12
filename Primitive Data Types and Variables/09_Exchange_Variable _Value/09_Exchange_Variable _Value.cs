using System;
//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

class Exchange_Variable_Value
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
        Console.WriteLine();
        a = b;
        b = c;
        Console.WriteLine("a= " + a);
        Console.WriteLine("b= " + b);
    }
}
