using System;

namespace _10_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Ricardo", 27);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hi " + name + " you are " + age);
        }
    }
}
