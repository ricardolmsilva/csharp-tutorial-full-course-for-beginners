using System;

namespace _16_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            //while (index <= 10) {
            //    Console.WriteLine(index);
            //    index++;
            //}

            do
            {
                index++;
                Console.WriteLine(index);
                
            }
            while (index <= 10);
           
        }
    }
}
