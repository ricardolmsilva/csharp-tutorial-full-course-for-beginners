using System;

namespace _27_Static_Methods_And_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //If class is defined as static, is not allowed to create an instance of it.
            //UsefulTools tools = new UsefulTools();

            //With static methods we can use that method without create an instance of this class.
            UsefulTools.SayHi("Ricardo");
        }
    }
}
