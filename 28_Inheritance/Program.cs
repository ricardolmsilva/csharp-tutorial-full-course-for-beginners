using System;

namespace _28_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChiken();

            //Italian Chef can do everything that normal Chef can do and can also do another stuff.
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChiken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();
        }
    }
}
