using System;

namespace OOP
{
    public class RetailSalesPerson : Salesman
    {
        public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this pen", this.FullName));
        }
    }
}