using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> salesman = new List<object> {new CarSalesman("James", "Weaver"), new CarSalesman("Felipe", "Brawn"), new RetailSalesPerson("Daphine", "Storm"), new InsuranceBroker("Alex", "Lima")};

            foreach(var item in salesman){
                showmeHowToSell(item);
            }

            Console.WriteLine("Exiting Program :)");
        }

        static void showmeHowToSell(Object salesman)
        {
            if (salesman is CarSalesman){
                CarSalesman carSalesman = (CarSalesman) salesman;
                carSalesman.Sell();
            }
            else if (salesman.GetType() == typeof(OOP.RetailSalesPerson))
            {
                RetailSalesPerson retailSalesPerson = (RetailSalesPerson) salesman;
                retailSalesPerson.Sell();
            }
            else
            {
                InsuranceBroker insuranceBroker = (InsuranceBroker) salesman;
                insuranceBroker.Sell();
            } 

            /*
                salesman.GetType()
                salesman.GetType() == typeof(OOP.CarSalesman)
                salesman is Carlesman
                salesman is RetailSalesPerson
            */
        }
    }
}
