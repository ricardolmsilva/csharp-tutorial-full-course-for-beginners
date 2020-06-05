using System;

namespace _12_If_Statments
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {

                Console.WriteLine("You're a tall male.");

            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You're a short male");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are not male but you're tall");
            }
            else
            {
                Console.WriteLine("You're not male and not tall");
            }
        }
    }
}
