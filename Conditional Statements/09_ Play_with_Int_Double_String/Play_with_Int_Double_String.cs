using System;
//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

class Play_with_Int_Double_String
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                Console.Write("Please enter a integer: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(i + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string st = Console.ReadLine();
                Console.WriteLine(st + "*");
                break;
            default:
                Console.WriteLine("ERROR");
                break;

        }
    }
}
