using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman steveTheSalesMan = new CarSalesman("Steve", "Rogers");
            Console.WriteLine(steveTheSalesMan.FullName);
            steveTheSalesMan.Sell();

            RetailSalesPerson erikTheSalesDude = new RetailSalesPerson("Erik","Erickson");
            Console.WriteLine(erikTheSalesDude.FullName);
            erikTheSalesDude.Sell();
        }
    }
}
