using System;

namespace _24_Object_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student StudentOne = new Student("Jim","Business", 2.8);
            Student StudentTwo = new Student("Pam", "Art", 3.6);


            Console.WriteLine(StudentOne.HasHonors());
            Console.WriteLine(StudentTwo.HasHonors());
        }
    }
}
