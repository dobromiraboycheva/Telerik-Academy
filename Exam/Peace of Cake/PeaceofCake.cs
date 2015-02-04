using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PeaceofCake
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());
        long f = a * d;
        long g = c * b;
        if((f+g)/(b*d)>=1)
        {
            Console.WriteLine((f + g) / (b * d));
            Console.WriteLine((f + g) +"/"+ (b * d));
        }
        else 
        {
            decimal result = Convert.ToDecimal(f + g) / Convert.ToDecimal(b * d); 
            Console.WriteLine("{0:F22}",result);
            Console.WriteLine((f + g) + "/" + (b * d));
        }
    }
}

