using System;
public class Diamonds
{
    public static void Main()
    {
        string userInput = Console.ReadLine();
        int size = int.Parse(userInput);
        int width = size * 2 + 1;
        int hight = 6 + ((size - 3) / 2) * 3;
        //top
        string topDots = new string('.', (width - size) / 2);
        string topStars = new string('*', size);
        Console.WriteLine("{0}{1}{0}", topDots, topStars);
        for (int i = 0; i < hight / 3 - 1; i++)
        {
            int dotsCount = (width - 3) / 4 - i;
            string startDots = new string('.', dotsCount);
            string middleDots = new string('.', (width-2*dotsCount - 3) / 2);
            Console.WriteLine("{0}*{1}*{1}*{0}", startDots, middleDots);
        }
        //mid
        string middleStras = new string('*', width);
        Console.WriteLine(middleStras);
        int middotscount = size - 2;
        for (int i = 0; i < size; i++)
        {
            int biggingDotsCount = i + 1;
            string startDots = new string('.', biggingDotsCount);
            if (middotscount >= 0)
            {
                string midDots = new string('.', middotscount);
                Console.WriteLine("{0}*{1}*{1}*{0}", startDots, midDots);
                middotscount--;
            }
            else
            {
                Console.WriteLine("{0}*{0}", startDots);
            }
        }

    }
}