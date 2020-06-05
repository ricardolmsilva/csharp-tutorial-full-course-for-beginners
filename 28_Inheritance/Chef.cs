using System;
namespace _28_Inheritance
{
    public class Chef
    {
        public void MakeChiken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        //Virtual means this method can be override in any sub-class
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }


    }
}
