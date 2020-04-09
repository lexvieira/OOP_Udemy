using System;

namespace OOP
{
    public class RetailSalesPerson : Salesman, SellDeveloping
    {
        public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void Develop()
        {
            Console.WriteLine("I develop myself by writting retail sales training videos");
            /*
                we can't do it we can't mess with the signature we can't touch this method well we can't change is
            */
        }

        public override void Sell()
        {
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this pen", this.FullName));
        }

    }
}