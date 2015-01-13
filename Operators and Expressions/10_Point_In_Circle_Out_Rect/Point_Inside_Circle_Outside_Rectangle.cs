using System;
//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class Point_Inside_Circle_Outside_Rectangle
{
    static void Main()
    {
        Console.Write("Enter radius R of circle: ");
        double R = double.Parse(Console.ReadLine());
        Console.Write("Cordinat X of the circle: ");
        double Xcenter = double.Parse(Console.ReadLine());
        Console.Write("Cordinat Y of the circle: ");
        double Ycenter = double.Parse(Console.ReadLine());
        Console.Write("Cordinat X of top left point of retangle: ");
        double XTopLeftRetangle = double.Parse(Console.ReadLine());
        Console.Write("Cordinat Y of top left point of retangle: ");
        double YTopLeftRetangle = double.Parse(Console.ReadLine());
        Console.Write("Height of retangle: ");
        double HeightRetangle = double.Parse(Console.ReadLine());
        Console.Write("Width of retangle: ");
        double WidthRetangle = double.Parse(Console.ReadLine());
        Console.WriteLine("How many point you want to check?");
        int NumberOfPints = int.Parse(Console.ReadLine());
        for (int j = 0; j < NumberOfPints; j++)
        {
            Console.Write("Enter x ordinat of your point:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y ordinat of your point: ");
            double y = double.Parse(Console.ReadLine());
            bool InTheCircle = false, OutOfRetangle = true;
            if (Math.Pow((x - Xcenter), 2) + Math.Pow((y - Ycenter), 2) <= Math.Pow(R, 2))
                InTheCircle = true;
            if (x >= XTopLeftRetangle && x <= XTopLeftRetangle + WidthRetangle && y <= YTopLeftRetangle && y >= YTopLeftRetangle - HeightRetangle)
                OutOfRetangle = false;
            if (InTheCircle & OutOfRetangle == true)
                Console.WriteLine("TRUE:The point is in the circle and out of the retangle");
            if (InTheCircle == true && OutOfRetangle == false)
                Console.WriteLine("FALSE:The point is in the circle and retangle");
            if (InTheCircle == false && OutOfRetangle == false)
                Console.WriteLine("FALSE:The point is out of the circle and in the retangle");
            if (InTheCircle == false && OutOfRetangle == true)
                Console.WriteLine("FALSE:The point is out of the circle and retangle");
        }
    }
}

