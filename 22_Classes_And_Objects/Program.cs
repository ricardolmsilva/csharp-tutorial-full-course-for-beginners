using System;

namespace _22_Classes_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book();
            bookOne.title = "Harry Potter";
            bookOne.author = "J. K. Rowling";
            bookOne.pages = 400;

            Book bookTwo = new Book();
            bookTwo.title = "Lord of the Rings";
            bookTwo.author = "Tolkein";
            bookTwo.pages = 700;

            Console.WriteLine(bookOne.title);
            Console.WriteLine(bookTwo.title);
        }
    }
}
