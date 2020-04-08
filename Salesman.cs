using System;
namespace OOP
{
    public abstract class Salesman
    {
        //Abstract Classes
        //https://www.udemy.com/course/beginner-object-oriented-programming-in-csharp-and-dotnet-core/learn/lecture/10716604#notes
        /*
            So the reason why we need to have a constructor in the concrete class is because we need to build the
            abstract class first before we can build anything else inheriting from it.
            Also a quick conversion the class inheriting from another class is called either a subclass or child class.

            And the class being inherited from is called a base class or planned class.
            In our case the salesman has a base class or parent class and the concrete classes are it's children or subclasses.
        */
        private string _firstName;

        private string _lastname;

        public string FullName{
            get {
                return string.Format("{0} {1}", this._firstName, this._lastname);
            }
        }
        public Salesman(string firstName, string lastName){
            this._firstName = firstName;
            this._lastname = lastName;
        }

        public virtual void Sell(){
            Console.WriteLine(String.Format("HI my name is {0}. I would recommend you to buy this item", this.FullName));            
        }
        
    }
}