using System;

namespace NumericTypes;

public class AreaOfRectangle
{
    public static void Main()
    {
            Console.WriteLine("Enter Length:");
            int Length = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter Height:");
            int Height = Convert.ToInt32 (Console.ReadLine());

            int Area = Length * Height;
            Console.WriteLine("The area of the rectangle is " + Area);
            Console.ReadKey();
    }
}