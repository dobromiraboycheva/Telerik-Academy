using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Binarry_digits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row <4; row++)
        {
            for (int bit = 15; bit >= 0; bit--)
            {
                bool isOne = ((1 << bit) & n) > 0;
                if(isOne)
                {
                    switch (row)
                    {
                        case 0:
                        case 2:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 3:
                            Console.Write("###");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (row)
                    {
                        case 0:
                        case 3:
                            Console.Write("###");
                            break;
                        case 1:
                        case 2:
                            Console.Write("#.#");
                            break;
                        default:
                            break;
                    }
                }
                if(bit>0)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

