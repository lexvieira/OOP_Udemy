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

            RetailSalesPerson johnTheSalesDude = new RetailSalesPerson("John","Doe");
            Console.WriteLine(johnTheSalesDude.FullName);
            erikTheSalesDude.Sell();            
        }
    }
}
