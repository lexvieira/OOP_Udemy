using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {


            RetailSalesPerson johnTheSalesDude = new RetailSalesPerson("John","Doe");
            Console.WriteLine(johnTheSalesDude.FullName);
            johnTheSalesDude.Sell();            

            WebDeveloper mike = new WebDeveloper("Angular 6");
            mike.Code();
            mike.Develop();
        }
    }
}
