using System;
using System.Collections.Generic;

class NightmareOnCodeStreet
{
    static void Main()
    
    {
        string inputLine = Console.ReadLine();
        int position = 0;
        int sum = 0;
        int counter = 0;
        foreach (var c in inputLine)
        {
            if (position % 2 != 0)
            {
                
                switch (c)
                {
                    case '0':
                        counter++;
                        break;
                    case '1':
                        counter++;
                        sum += 1;
                        break;
                    case '2':
                        counter++;
                        sum += 2;
                        break;
                    case '3':
                        counter++;
                        sum += 3;
                        break;
                    case '4':
                        counter++;
                        sum += 4;
                        break;
                    case '5':
                        counter++;
                        sum += 5;
                        break;
                    case '6':
                        counter++;
                        sum += 6;
                        break;
                    case '7':
                        counter++;
                        sum += 7;
                        break;
                    case '8':
                        counter++;
                        sum += 8;
                        break;
                    case '9':
                        counter++;
                        sum += 9;
                        break;
                }
            }
            position++;
        }
        Console.WriteLine(counter+" "+sum);
       
    }
}
