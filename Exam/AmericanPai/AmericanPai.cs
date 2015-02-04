using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AmericanPai
{
    static void Main()
    {
      
        long A = long.Parse(Console.ReadLine());
        
        long B = long.Parse(Console.ReadLine());
     
        long C = long.Parse(Console.ReadLine());
 
        long D = long.Parse(Console.ReadLine());
        long AC = A * D + C * B;
        long BD = B * D;
        if(AC>BD)
        {
            Console.WriteLine(AC/BD);
        }
        else
        {
            
            decimal result = Convert.ToDecimal( AC) / Convert.ToDecimal( BD);
            Console.WriteLine("{0:F20}",result);
        }
        Console.WriteLine(AC+"/"+BD);
    }
}

