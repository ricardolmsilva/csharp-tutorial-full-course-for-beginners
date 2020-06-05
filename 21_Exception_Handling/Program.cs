using System;

namespace _21_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numOne;
                int numTwo;

                Console.Write("Enter a number: ");
                numOne = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                numTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numOne / numTwo);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Bye");
            }
            
            
        }
    }
}
