using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salesman> salesman = new List<Salesman> {new CarSalesman("James", "Weaver"), new CarSalesman("Felipe", "Brawn"), new RetailSalesPerson("Daphine", "Storm"), new InsuranceBroker("Alex", "Lima"), new OnlineMaraketer("Steve", "Rogers")};
            //Change the Object type to Salesman
            foreach(var item in salesman){
                showmeHowToSell(item);
            }

            Console.WriteLine("Exiting Program :)");
        }

        static void showmeHowToSell(Salesman salesman)
        {
            //Repeat here the same - Change the Object type to Salesman
            //Instead use the conditional verification, just call the methods directly
            salesman.Sell();

            /*
                salesman.GetType()
                salesman.GetType() == typeof(OOP.CarSalesman)
                salesman is Carlesman
                salesman is RetailSalesPerson
            */

            /*It just says as long as you are of salesman type so you are inheriting from a salesman.
              If this parent class is pointing to any of these child classes it will be able to take care of it and
              call its sell method.
            */
        }
    }
}
