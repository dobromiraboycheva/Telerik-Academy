using System;
//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
class Number_as_Words
{
    static void Main()
    {
        int num = new int();
        Console.Write("Enter numer between 0 and 999: ");
        bool Valid = int.TryParse(Console.ReadLine(), out num);
        if (Valid)
        {
            if (num >= 0 && num <= 999)
            {
                int num1 = (num % 10);
                int num10 = (num / 10 % 10);
                int num100 = (num / 100);
                switch (num100)
                {
                    case 1:
                        Console.Write("One hundred and ");
                        break;
                    case 2:
                        Console.Write("Two hundred and ");
                        break;
                    case 3:
                        Console.Write("Three hundred and ");
                        break;
                    case 4:
                        Console.Write("Four hundred and ");
                        break;
                    case 5:
                        Console.Write("Five hundred and ");
                        break;
                    case 6:
                        Console.Write("Six hundred and ");
                        break;
                    case 7:
                        Console.Write("Seven hundred and ");
                        break;
                    case 8:
                        Console.Write("Eight hundred and ");
                        break;
                    case 9:
                        Console.Write("Nine hundred and ");
                        break;
                    default:
                        Console.Write("");
                        break;
                }
                switch (num10)
                {
                    case 1:
                        switch (num1)
                        {
                            case 1:
                                Console.WriteLine("Eleven");
                                break;
                            case 2:
                                Console.WriteLine("Twelve");
                                break;
                            case 3:
                                Console.WriteLine("Thirteen");
                                break;
                            case 4:
                                Console.WriteLine("Fourteen");
                                break;
                            case 5:
                                Console.WriteLine("Fifteen");
                                break;
                            case 6:
                                Console.WriteLine("Sixteen");
                                break;
                            case 7:
                                Console.WriteLine("Seventeen");
                                break;
                            case 8:
                                Console.WriteLine("Eighteen");
                                break;
                            case 9:
                                Console.WriteLine("Nineteen");
                                break;
                            case 0:
                                Console.WriteLine("Ten");
                                break;
                            default:
                                Console.Write("");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Twenty ");
                        break;
                    case 3:
                        Console.Write("Thirty ");
                        break;
                    case 4:
                        Console.Write("Forty ");
                        break;
                    case 5:
                        Console.Write("Fifty ");
                        break;
                    case 6:
                        Console.Write("Sixty ");
                        break;
                    case 7:
                        Console.Write("Seventy ");
                        break;
                    case 8:
                        Console.Write("Eighty ");
                        break;
                    case 9:
                        Console.Write("Ninety ");
                        break;
                    default:
                        break;
                }
                if (num10 != 1)
                {
                    switch (num1)
                    {
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                        case 0:
                            Console.WriteLine("Zero");
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Your number in not betwwen 0 and 999");
            }

        }
        else
        {
            Console.WriteLine("Invalid format");
        }
    }
}