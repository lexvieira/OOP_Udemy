using System;
namespace OOP
{
    public interface Salesman
    {
        // Construct Interface
        // https://www.udemy.com/course/beginner-object-oriented-programming-in-csharp-and-dotnet-core/learn/lecture/10716612#notes
        /*
            Can only have declarations.
            We can have virtual abstract now that just a signature of the method and our property defined in an
            abstract manner.
            So that means that we can just say that full name is a property and it has a get method but we can't
            say what that get method does.        
        */

        string FullName{ get; }

        void Sell();
        
    }
}