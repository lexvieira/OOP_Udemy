using System;

namespace OOP
{
    public class RetailSalesPerson : Salesman, SellDeveloping //Regulation with Interface
    /* But when we enforce it with an interface and then we mess with the method again see we get regulation in place.
       So that is the beauty of interfaces and also the fact that it gets around the problem of multiple inheritance in C sharp.

       Quiz: 
       What is Inheritance in Object Oriented Programming?
       It is a process of creating a new object from an existing object and gaining access to their classes members.
       
       Abstract Classes are used for... Interfaces are used for...
       Abstract Classes are used for grouping related group of classes and uniting their functionality in one place 
       and Interfaces are used for grouping unrelated group of classes.
    */
    {
        public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //Fixing bring the method again to the code, giving stabililty to the code
        public void Develop()
        {
            Console.WriteLine("I develop myself by writting retail sales training videos");
        }

        public override void Sell()
        {
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this pen", this.FullName));
        }

    }
}