using System;

namespace _17_Building_a_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessLimit = 5;

            do
            {
                Console.WriteLine("You have " + guessLimit + " chances remaining");
                Console.Write("Enter a guess: ");
                guess = Console.ReadLine().ToLower();
                guessLimit--;
                Console.Clear();

            } while (guess != secretWord && guessLimit != 0);


            if (secretWord == guess)
            {
                Console.WriteLine("Congratulations you won!");
                return;
            }

            if (guessLimit == 0)
            {
                Console.WriteLine("Game Over");
                return;

            }
        }
    }
}
