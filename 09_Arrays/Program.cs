using System;

namespace _09_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumbers = {1, 2, 3};
            string[] friends = new string[5];

            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Josh";
            friends[3] = "Jess";
            friends[4] = "Sophie";

            luckyNumbers[2] = 900;
            Console.WriteLine(luckyNumbers[2]);
        }
    }
}
