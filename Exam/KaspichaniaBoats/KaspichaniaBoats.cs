using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width=n*2+1;
        int hight = 6 + ((n - 3) / 2) * 3;
        int[,] matrix = new int[hight, width];
       //Statments
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if(row==n)
                {
                    matrix[row, col] = 1;
                }
                if((row==1)&&(col==n-1||col==n+1))
                {
                    matrix[row, col] = 1;
                }
                if (row==hight-1&&(col>=width/2-n/2&&col<width-n/2-1))
                {
                    matrix[row, col] = 1;
                }
                if(row>=0&&row<width&&col==n)
                {
                    matrix[row, col] = 1;
                }
                if(row>1&&row<n&&(col==n-row||col==n+row))
                {
                    matrix[row, col] = 1;
                }
                if(row>n&&row<hight-1&&(col==row-n||col==width+n-row-1))
                {
                    matrix[row, col] = 1;
                }
            }
        }

        //OutPut
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if(matrix[row,col]==1)
                {
                    Console.Write('*');
                }

            }
            Console.WriteLine();
        }

    }
}

