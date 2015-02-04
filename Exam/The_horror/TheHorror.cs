using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheHorror
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        int position = 0;
        int counter = 0;
        int result = 0;
        foreach (char number in numbers)
        {
            if(position%2==0)
                switch (number)
                {
                        case '0':
                        counter++;
                        break;
                    case '1':
                        counter++;
                        result += 1;
                            break;
                    case '2':
                            counter++;
                            result += 2;
                            break;
                    case '3':
                            counter++;
                            result += 3;
                            break;
                    case '4':
                            counter++;
                            result += 4;
                            break;
                    case '5':
                            counter++;
                            result += 5;
                            break;
                    case '6':
                            counter++;
                            result += 6;
                            break;
                    case '7':
                            counter++;
                            result += 7;
                            break;
                    case '8':
                            counter++;
                            result += 8;
                            break;
                    case '9':
                            counter++;
                            result += 9;
                            break;
                }
            position++;
        }
        Console.WriteLine(counter+" "+result);
    }
}

