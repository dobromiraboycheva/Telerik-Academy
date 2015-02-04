using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Warhead
    {
        const int n = 16;
        static int[,] matrix = new int[n, n];

        static void Main()
        {
            Input();
            Commands();
        }

        private static void Input()
        {
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(input[col].ToString());
                }
            }
        }

        private static void Commands()
        {
            bool isGame = true;
            while (isGame)
            {
                string text = Console.ReadLine();
                switch (text)
                {
                    case "hover":
                        {
                            int row = int.Parse(Console.ReadLine());
                            int col = int.Parse(Console.ReadLine());
                           
                            if (matrix[row, col] == 1)
                            {
                                Console.WriteLine("*");
                            }
                            else
                            {
                                Console.WriteLine("-");
                            }
                            break;
                        }
                    case "operate":
                        {
                            int row = int.Parse(Console.ReadLine());
                            int col = int.Parse(Console.ReadLine());
                            if (matrix[row, col] == 1)
                            {
                                Console.WriteLine("missed");
                                Console.WriteLine(GetShape("blue") + GetShape("red"));
                                Console.WriteLine("BOOM");
                                isGame = false;
                            }
                            else if (IsFigure(row, col))
                            {
                                RemoveFigure(row, col);
                            }
                            break;
                        }
                    case "cut":
                        {
                            string section = Console.ReadLine();
                            int sectionFigure = GetShape(section);
                            if (sectionFigure > 0)
                            {
                                Console.WriteLine(sectionFigure);
                                Console.WriteLine("BOOM");
                            }
                            else
                            {
                                string otherSection = "";
                                if (section == "red" || section == "left")
                                {
                                    otherSection = "blue";
                                }
                                else if (section == "blue" || section == "right")
                                {
                                    otherSection = "red";
                                }
                                Console.WriteLine(GetShape(otherSection));
                                Console.WriteLine("disarmed");
                            }
                            isGame = false;
                            break;
                        }
                    default:
                        break;
                }
            }
        }


        private static int GetShape(string sector)
        {
            int starCol;
            int endCol;
            if (sector == "red")
            {
                starCol = 1;
                endCol = 7;
            }
            else
            {
                starCol = 8;
                endCol = 14;
            }
            int figureCounter = 0;
            for (int i = 1; i < 15; i++)
            {
                for (int j = starCol; j <= endCol; j++)
                {
                    if (IsFigure(i, j))
                    {
                        figureCounter++;
                    }
                }
            }
            return figureCounter;
        }

        private static bool IsFigure(int row, int col)
        {
            if (row == 0 || row == 15 || col == 0 || col == 15)
            {
                return false;
            }
            bool IsFigure = matrix[row, col] == 0 &&
                matrix[row - 1, col] == 1 &&
                matrix[row - 1, col - 1] == 1 &&
                matrix[row - 1, col + 1] == 1 &&
                matrix[row + 1, col] == 1 &&
                matrix[row + 1, col - 1] == 1 &&
                matrix[row + 1, col + 1] == 1 &&
                matrix[row, col - 1] == 1 &&
                matrix[row, col + 1] == 1;
            return IsFigure;
        }
        private static void RemoveFigure(int row, int col)
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

    }
