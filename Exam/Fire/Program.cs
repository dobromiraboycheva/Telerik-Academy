using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n;
        int hight = n/2+n/4+1+n/2;
        string[,] matrix = new string[hight, width];

        //Input
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = ".";
            }
        }
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if(row==0&&(col==n/2-1||col==n/2))
                {
                    matrix[row, col] = "#";
                }
                else if(row>0&&row<n/2&&(col==n/2-1-row||col==n-(n/2-row)))
                {
                     matrix[row, col] = "#";
                }
                else if(row>=n/2&&row<(n/2+n/4)&&(col==(row-n/2)||col==width-1-(row-n/2)))
                {
                    matrix[row, col] = "#";
                }
                else if(row==n/2+n/4)
                {
                    matrix[row, col] = "-";
                }
                else if(row>n/2+n/4&&(col>=row-1-(n/2+n/4)&&col<n/2))
                {
                     matrix[row, col] = "\\";
                }
                else if (row > n / 2 + n / 4 && (col >= n / 2 &&col <= width-(row  - (n / 2 + n / 4)) ))
                {
                    matrix[row, col] = "/";
                }
            }
        }
        //Output
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}

