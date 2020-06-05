using System;

namespace _25_Getters_And_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            // G, PG, PG-13, R, NR
            Movie avengers = new Movie("The Avengers", "Joss", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            avengers.Rating = "Cat";

            Console.WriteLine(avengers.Rating);
        }
    }
}
