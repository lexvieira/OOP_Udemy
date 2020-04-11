using System;

namespace OOP
{
    public class InsuranceBroker : Salesman
    {
        public InsuranceBroker(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //Fixing bring the method again to the code, giving stabililty to the code

        public override void Sell()
        {
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this Insurance", this.FullName));
        }
    }
}