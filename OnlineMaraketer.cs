using System;

namespace OOP
{
    public class OnlineMaraketer : Salesman
    {
        public OnlineMaraketer(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this online product", this.FullName));
        }

        protected override void AddressConcerns()
        {
            throw new NotImplementedException();
        }

        protected override void Close()
        {
            throw new NotImplementedException();
        }

        protected override void DemoValue()
        {
            throw new NotImplementedException();
        }

        protected override void Engage()
        {
            throw new NotImplementedException();
        }

        protected override void EstablishTrust()
        {
            throw new NotImplementedException();
        }
    }
}