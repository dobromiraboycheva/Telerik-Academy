using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FallDown
{
    static void Main()
    {
        int[] n = new int[8];
        for (int i = 0; i < 8; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < 8; j++)
        {
            for (int i = 7; i >= 1; i--)
            {
                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n[i] >> bitposition & 1) == 0 &&
                       (n[i - 1] >> bitposition & 1) == 1)
                    {
                        n[i] |= (1 << bitposition);
                        n[i - 1] ^= (1 << bitposition);
                    }
                }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(n[i]);
        }
    }
}

