using System;
namespace OOP
{
    public class WebDeveloper : Developer, SellDeveloping
    {
        public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
        {
        }

        public void Develop()
        {
            /*  No Regulation
                Here and here we don't have that same stability.
                Anybody can come in and do whatever they want they can change the name of develop they can make it return
                a type they can basically take it out and put it somewhere else and there is no way for us to tell that
                other person that it is a required thing.
            */
            Console.WriteLine("I develop myself by watching Udemy Web Develop Courses");
        }
        /*
            For example when we have an abstract method in an abstract class and we inherit from the abstract class
            it it forces us to overwrite it and have our own definition.
            If we don't do it the program won't run.
            This is a great reminder which introduces stability and regulation into our program.
            Since anybody making a child class in inheriting from the base class which has an abstract method would
            have to define that method in our case there are no rules to regulate as to which class has to have
            self development ability.
        */

    }
}