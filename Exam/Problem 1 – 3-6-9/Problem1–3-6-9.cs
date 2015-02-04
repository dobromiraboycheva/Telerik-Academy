using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Proble1_3_6_9
{
    static void Main()
    {
        
        long a = long.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long r = 0;
        switch (b)
        {
            case 3:
                r = a + c;
                break;
            case 6:
                r = a * c;
                break;
            case 9:
                r = a % c;
                break;
        }
        if(r%3==0)
        {
            Console.WriteLine(r/3);
        }
        else
        {
            Console.WriteLine(r%3);
        }
        Console.WriteLine(r);
    }
}

