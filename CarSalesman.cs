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
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this car", this.FullName));
        }
    }
}