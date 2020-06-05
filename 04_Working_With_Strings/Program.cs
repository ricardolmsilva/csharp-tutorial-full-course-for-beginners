using System;

namespace _04_Working_With_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy " + "is cool!";
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.Contains('s'));
            //Console.WriteLine(phrase[1]);
            //Console.WriteLine(phrase.IndexOf('f'));
            Console.WriteLine(phrase.Substring(8,3));
        }
    }
}
