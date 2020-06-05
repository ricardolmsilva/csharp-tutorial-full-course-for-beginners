using System;

namespace _06_Getting_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hey " + name + " you are " + age);
        }
    }
}
