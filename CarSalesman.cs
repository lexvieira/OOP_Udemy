using System;

namespace OOP
{
    public class CarSalesman : Salesman
    {
        public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }
        public override void Sell() //Override is used only with Abstract Classes
        {
            //Method is required, needs to have its own definition
            //Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this car", this.FullName));
            //Called a protected method
            this.Engage();
            this.EstablishTrust();
            this.AddressConcerns();
            this.DemoValue();
            this.Close();
        }

        protected override void Engage()
        {
            Console.WriteLine("Hello!");
        }

        protected override void EstablishTrust()
        {
            Console.WriteLine("I just want to quickly help you");
        }
        protected override void AddressConcerns()
        {
            Console.WriteLine("Everthing 10% discount!");
        }

        protected override void DemoValue()
        {
            Console.WriteLine("Our costomers Love It");
        }
        protected override void Close()
        {
            Console.WriteLine("Buy this car!");
        }

    }
}