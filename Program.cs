using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salesman> salesman = new List<Salesman> {new CarSalesman("James", "Weaver"), new CarSalesman("Felipe", "Brawn"), new RetailSalesPerson("Daphine", "Storm"), new InsuranceBroker("Alex", "Lima"), new OnlineMaraketer("Steve", "Rogers")};
            foreach(var item in salesman){
                showmeHowToSell(item);
            }

            List<SellDeveloping> sellDeveloping = new List<SellDeveloping> {new RetailSalesPerson("Daphine", "Storm"), new WebDeveloper("C#")};
            /*SellDeveloping instead a Object 
                This can get into it just as simply but if we put self developing interface what this does is it creates
                a regulation it creates boundaries around what can get into this list and what can not get into this list.
            */
            foreach(var item in sellDeveloping){
                showMeHowYouSelfDevelop(item);
            }


            HowIGoToWork howIGoToWork = new HowIGoToWork("Alex", "Viera", 7);

            howIGoToWork.WakeUp();

            howIGoToWork.BrushMyTeeth();

            howIGoToWork.Workout();

            howIGoToWork.GetIntoMyCar();

            howIGoToWork.StartDriving();

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

        static void showMeHowYouSelfDevelop(SellDeveloping sellDeveloping)
        {
            sellDeveloping.Develop();
        }

        /*
            Dynamic Polymorphism
            For example when we have an abstract method in an abstract class and we inherit from the abstract class
            it it forces us to overwrite it and have our own definition.
            If we don't do it the program won't run.
            This is a great reminder which introduces stability and regulation into our program.
            Since anybody making a child class in inheriting from the base class which has an abstract method would
            have to define that method in our case there are no rules to regulate as to which class has to have
            self development ability.

            Static Polymorphism is using method overloading and Dynamic Polymorphism is using 
            method overriding.
            This is the right answer because Static Polymorphism is using method overloading 
            within each class and Dynamic Polymorphism is using method overriding in many classes
            inheriting from a base class such as an Abstract Class or an Interface.

            https://stackoverflow.com/questions/20783266/what-is-the-difference-between-dynamic-and-static-polymorphism-in-java
        */

    }
}
