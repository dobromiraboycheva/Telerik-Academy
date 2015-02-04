
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class XExpression
{
    static void Main()
    {
        int symbol = Console.Read();
        decimal sum = 0;
        int result = 0;
        int o = '+';
        while (symbol != '=')
        {
            if (symbol == '(')
            {
                decimal innerSum = 0;
                int inner0 = '+';
                symbol = Console.Read();
                while (symbol != ')')
                {
                    if (0 <= symbol - '0' && symbol - '0' <= 9)
                    {
                        switch (inner0)
                        {
                            case '+':
                                innerSum += symbol - '0';
                                break;
                            case '*':
                                innerSum *= symbol - '0';
                                break;
                            case '/':
                                innerSum /= symbol - '0';
                                break;
                            case '-':
                                innerSum -= symbol - '0';
                                break;
                        }
                    }
                    else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                    {
                        inner0 = symbol;
                    }
                    symbol = Console.Read();

                }
                switch (o)
                {
                    case '+':
                        sum += innerSum;
                        break;
                    case '*':
                        sum *= innerSum;
                        break;
                    case '/':
                        sum /= innerSum;
                        break;
                    case '-':
                        sum -= innerSum;
                        break;
                }
            }
            else if (0 <= symbol - '0' && symbol - '0' <= 9)
            {
                switch (o)
                {
                    case '+':
                        sum += symbol - '0';
                        break;
                    case '*':
                        sum *= symbol - '0';
                        break;
                    case '/':
                        sum /= symbol - '0';
                        break;
                    case '-':
                        sum -= symbol - '0';
                        break;
                }
            }
            else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
            {
                o = symbol;
            }
            symbol = Console.Read();
        }
        Console.WriteLine("{0:0.00}", sum);
    }
}
