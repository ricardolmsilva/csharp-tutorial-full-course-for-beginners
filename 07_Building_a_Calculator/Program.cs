using System;

namespace _07_Building_a_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne;
            double numTwo;

            Console.Write("Enter a number: ");
            numOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            numTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(numOne + numTwo);
        }
    }
}
    