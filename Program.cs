using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            CarSalesman carSalesman1 = new CarSalesman("James", "Weaver");
            carSalesman1.Sell();

            CarSalesman carSalesman2 = new CarSalesman("Felipe", "Brawn");
            carSalesman2.Sell();

            RetailSalesPerson retailSalesman1 = new RetailSalesPerson("Daphine", "Storm");
            retailSalesman1.Sell();

        /*
            There's a base class for everything in C sharp so we can take advantage of that and say hey our list
            can take anything including salesman shop classes or any other type.
            It's all inclusive.
        */

        }
    }
}
