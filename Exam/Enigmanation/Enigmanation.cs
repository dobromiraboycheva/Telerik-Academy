using System;



class Enigmanation
    {
    static void Main()
        {
        int symbol = Console.Read();
        decimal sum = 0;
        int operators = '+';
        while (symbol != '=')
            {
            if (symbol == '(')
                {
                decimal innerSum = 0;
                int innerOperator = '+';
                symbol = Console.Read();
                while (symbol != ')')
                    {
                    if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {

                        switch (innerOperator)
                            {
                            case '+':
                                innerSum += symbol - '0';
                                break;
                            case '*':
                                innerSum *= symbol - '0';
                                break;
                            case '%':
                                innerSum %= symbol - '0';
                                break;
                            case '-':
                                innerSum -= symbol - '0';
                                break;
                            default:
                                break;
                            }
                        }

                    else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '%')
                        {
                        innerOperator = symbol;
                        }
                    symbol = Console.Read();
                    }
                switch (operators)
                    {
                    case '+':
                        sum +=innerSum;
                        break;
                    case '*':
                        sum *= innerSum ;
                        break;
                    case '%':
                        sum %= innerSum;
                        break;
                    case '-':
                        sum -= innerSum ;
                        break;
                    default:
                        break;
                    }
                }
            else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                switch (operators)
                    {
                    case '+':
                        sum += symbol - '0';
                        break;
                    case '*':
                        sum *= symbol - '0';
                        break;
                    case '%':
                        sum %= symbol - '0';
                        break;
                    case '-':
                        sum -= symbol - '0';
                        break;
                    default:
                        break;
                    }
                }

            else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '%')
                {
                operators = symbol;
                }
            symbol = Console.Read();
            }
        Console.WriteLine("{0:0.000}", sum);
        }
    }