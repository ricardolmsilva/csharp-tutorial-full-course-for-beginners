using System;

namespace _26_Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kasmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine("Was created " + Song.songCount + " sounds.");
            Console.WriteLine(kasmir.getSongCount());
        }
    }
}
