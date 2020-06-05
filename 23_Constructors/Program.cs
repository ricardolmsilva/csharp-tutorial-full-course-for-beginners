using System;

namespace _23_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Harry Potter", "J.K Rowling", 300);

            Book bookTwo = new Book("Lord Of the Rings", "Tolkein", 700);

            Console.WriteLine(bookOne.title);
            Console.WriteLine(bookTwo.title);
        }
    }
}
