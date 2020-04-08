using System;

namespace OOP
{
    public class CarSalesman
    {
        private string _firstName;

        private string _lastname;

        public string FullName{
            get {
                return string.Format("{0} {1}", this._firstName, this._lastname);
            }
        }
        public CarSalesman(string firstName, string lastName){
            this._firstName = firstName;
            this._lastname = lastName;
        }

        public void Sell()
        {
            Console.WriteLine(string.Format("Hi, my name is {0}. I would recommend you to buy this card", this.FullName));
        }
    }
}