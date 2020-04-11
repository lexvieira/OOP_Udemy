using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> salesman = new List<object> {new CarSalesman("James", "Weaver"), new CarSalesman("Felipe", "Brawn"), new RetailSalesPerson("Daphine", "Storm")};

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
            else
            {
                RetailSalesPerson retailSalesPerson = (RetailSalesPerson) salesman;
                retailSalesPerson.Sell();
            }

            /*
                salesman.GetType()
                salesman is Carlesman
                salesman is RetailSalesPerson
            */
        }
    }
}
