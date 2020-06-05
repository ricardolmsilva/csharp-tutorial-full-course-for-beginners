using System;

namespace _13_If_Statements_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2,10, 50));
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >=num3)
            {
                result = num1;
            }
            else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}
