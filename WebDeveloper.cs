using System;
namespace OOP
{
    public class WebDeveloper : Developer
    {
        public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
        {
        }

        public void Develop()
        {
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