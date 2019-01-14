using System;

namespace Rectangle
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");

            // Get input from the user and save it to a variable.
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");

            // Get input from the user and save it to a second variable.
            double width = double.Parse(Console.ReadLine());

            // Output - The area of the rectangle is (computed value)
            Console.WriteLine("Area of the rectangle is --- " + (length * width));

            Console.ReadLine();

            //  NOTE there is no try/catch logic here to validate input.  
            //  we are trusting the user to enter only numeric data.
        }
    }
}
