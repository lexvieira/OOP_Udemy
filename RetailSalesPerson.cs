using System;

namespace OOP
{
    public class RetailSalesPerson : Salesman, SellDeveloping //Regulation with Interface
    /* But when we enforce it with an interface and then we mess with the method again see we get regulation in place.
       So that is the beauty of interfaces and also the fact that it gets around the problem of multiple inheritance in C sharp.
    */
    {
        public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //Messing Everthing Removing a important part of the code
        // public void Develop()
        // {
        //     Console.WriteLine("I develop myself by writting retail sales training videos");
        //     /*
        //         we can't do it we can't mess with the signature we can't touch this method well we can't change is
        //     */
        // }

        public override void Sell()
        {
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this pen", this.FullName));
        }

    }
}