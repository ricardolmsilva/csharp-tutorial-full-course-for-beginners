using System;

namespace _20_2d_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = {
                {1, 2},
                {3, 4 }, //1 1
                {5, 6 },
            };


            Console.WriteLine(numberGrid[1, 1]);
        }
    }
}
