using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Apple_or_Orange
{
    static void Main()
    {
        long Number = long.Parse(Console.ReadLine());
        if(Number<0)
        {
            Number = -Number;
        }
        int OddSum = 0;
        int EvenSum = 0;
        while(Number>0)
        {
            byte digit = (byte)(Number % 10);
            if(digit%2==0)
            {
                OddSum += digit; 
            }
            else
            {
                EvenSum += digit;
            }
            Number /= 10;
        }
        if(OddSum>EvenSum)
        {
            Console.WriteLine("Apple {0}",OddSum);
        }
        else if(OddSum<EvenSum)
        {
            Console.WriteLine("Orange {0}",EvenSum);
        }
        else if(OddSum==EvenSum)
        {
            Console.WriteLine("Both {0}",OddSum);
        }
    }
}

