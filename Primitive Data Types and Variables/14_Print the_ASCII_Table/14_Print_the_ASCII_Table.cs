using System;
using System.Text;
//Problem 14.* Print the ASCII Table

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

    class Print_the_ASCII_Table
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
            for (int i = 1; i <=255; i++)
            {
                Console.WriteLine("i={0} \t symbol= {1}", i, (char)i);
            }
        }
    }

