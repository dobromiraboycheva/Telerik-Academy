using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class AngryFemaleGPS
{
    static void Main()
    {
        long number =long.Parse( Console.ReadLine());
        BigInteger oddSum=0;
        BigInteger evenSum=0;
        if(number<0)
        {
            number = -number;
        }
        while(number>0)
        {
            byte digit = (byte)(number % 10);
            
            if(digit%2==0)
            {
                evenSum +=digit;
            }
            else
            {
                oddSum +=digit;
            }
            number /= 10;
        }
        if(evenSum>oddSum)
        {
            Console.WriteLine("right {0}",evenSum);
        }
        else if(evenSum<oddSum)
        {
            Console.WriteLine("left {0}",oddSum);
        }
        else if(evenSum==oddSum)
        {
            Console.WriteLine("straight {0}",evenSum);
        }
    }
}

