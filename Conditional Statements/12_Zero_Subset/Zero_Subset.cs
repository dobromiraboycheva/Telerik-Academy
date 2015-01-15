using System;
//Problem 12.* Zero Subset

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

class Zero_Subset
{
    static void Main()
    {
        bool found = false;
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c= ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d= ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e= ");
        int e = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int p = 0; p < 2; p++)
                    {
                        for (int q = 0; q < 2; q++)
                            if (i != 0 || j != 0 || k != 0 || p != 0 || q != 0)
                            {
                                sum = a * i + b * j + c * k + d * p + e * q;
                                if (sum == 0)
                                {
                                    if (a * i != 0 || a == 0)
                                    {
                                        Console.Write("{0}+", a);
                                    }
                                    if (b * j != 0 || b == 0)
                                    {
                                        Console.Write("{0}+", b);
                                    }
                                    if (c * k != 0 || c == 0)
                                    {
                                        Console.Write("{0}+", c);
                                    }
                                    if (d * p != 0 || d == 0)
                                    {
                                        Console.Write("{0}+", d);
                                    }
                                    if (e * q != 0 || e == 0)
                                    {
                                        Console.Write("{0}", e);
                                    }
                                    Console.WriteLine("=0");
                                    found = true;
                                }

                            }
                    }
                }
            }
        }
        if (found == false)
        {
            Console.WriteLine("No zero subset!");
        }
        //if (a + b == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", a, b);
        //    found = true;
        //}
        //if (a + c == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", a, c);
        //    found = true;
        //}
        //if (a + d == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", a, d);
        //    found = true;
        //}
        //if (a + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", a, b);
        //    found = true;
        //}
        //if (b + c == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", b, c);
        //    found = true;
        //}
        //if (b + d == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", b, d);
        //    found = true;
        //}
        //if (b + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", b, e);
        //    found = true;
        //}
        //if (c + d == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", c, d);
        //    found = true;
        //}
        //if (c + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", c, e);
        //    found = true;
        //}
        //if (d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}=0", d, e);
        //    found = true;
        //}
        //if (a + b + c == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", a, b, c);
        //    found = true;
        //}
        //if (a + b + d == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", a, b, d);
        //    found = true;
        //}
        //if (a + b + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", a, b, e);
        //    found = true;
        //}
        //if (a + c + d == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", a, c, d);
        //    found = true;
        //}
        //if (a + c + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", a, c, e);
        //    found = true;
        //}
        //if (a + d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", a, d, e);
        //    found = true;
        //}
        //if (b + c + d == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", b, c, d);
        //    found = true;
        //}
        //if (b + c + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", b, c, e);
        //    found = true;
        //}
        //if (b + d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", b, d, e);
        //    found = true;
        //}
        //if (c + d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}=0", c, d, e);
        //    found = true;
        //}
        //if (a + b + c + d == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, d);
        //    found = true;
        //}
        //if (a + b + c + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, e);
        //    found = true;
        //}
        //if (a + b + d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, d, e);
        //    found = true;
        //}
        //if (a + c + d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}+{3}=0", a, c, d, e);
        //    found = true;
        //}
        //if (b + c + d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}+{3}=0", b, c, d, e);
        //    found = true;
        //}
        //if (a + b + c + d + e == 0)
        //{
        //    Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", a, b, c, d, e);
        //    found = true;
        //}
        //if (a == 0)
        //{
        //    Console.WriteLine("{0}=0", a);
        //    found = true;
        //}
        //if (b == 0)
        //{
        //    Console.WriteLine("{0}=0", b);
        //    found = true;
        //}
        //if (c == 0)
        //{
        //    Console.WriteLine("{0}=0", c);
        //    found = true;
        //}
        //if (d == 0)
        //{
        //    Console.WriteLine("{0}=0", d);
        //    found = true;
        //}
        //if (e == 0)
        //{
        //    Console.WriteLine("{0}=0", e);
        //    found = true;
        //}
        //if (found == false)
        //{
        //    Console.WriteLine("No zero subset");
        //}
    }
}