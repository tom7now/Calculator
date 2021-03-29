using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length;
            decimal width;
            decimal overage;
            string input;

            Console.Write("Enter the length of the room: ");
            input = Console.ReadLine();

            length = decimal.Parse(input);

            Console.Write("Enter the width of the room: ");
            input = Console.ReadLine();

            width = decimal.Parse(input);

            Console.Write("Enter the overage percent: ");
            input = Console.ReadLine();

            overage = decimal.Parse(input) / 100;

            decimal area = length * width;

            overage *= area;

            area += overage;

            Console.WriteLine($"The total area, including overage, is: {area}");
        }
    }
}
