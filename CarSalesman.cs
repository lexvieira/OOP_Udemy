using System;

namespace OOP
{
    public class CarSalesman : Salesman, SalesmanLittle
    /*
        It says class car salesman cannot have multiple base classes.
        And that's because we cannot inherit from multiple classes.
    */
    {
        public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this car", this.FullName));
        }
    }
}