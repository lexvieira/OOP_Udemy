using System;
namespace OOP
{
    public class Developer
    {
        private string _mainDevLanguage;


        public Developer(string mainDevLanguage){
            this._mainDevLanguage = mainDevLanguage;
        }

        public virtual void Code(){
            Console.WriteLine(String.Format("Hi, I'm coding using my main Dev Language {0}", this._mainDevLanguage));
        }

        public virtual void Code(string extraDevLanguage){
            Console.WriteLine(String.Format("I'm coding using my main Dev Language {0}. Additionaly, I'm using the {1} as extra de languages", this._mainDevLanguage, extraDevLanguage));                    
        }

        public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLanguage){
            Console.WriteLine(String.Format("I'm coding using my main Dev Language {0}. Additionaly, I'm using the {1} and {2} as extra de languages", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));                    
        }

        public virtual void Code(string firstExtraDevLanguage, int yearExperience){
            Console.WriteLine(String.Format("I'm coding using my main Dev Language {0}. Additionaly, I'm using the {1} as extra de languages, having {2} years of experience", this._mainDevLanguage, firstExtraDevLanguage, yearExperience));                    
        }

        public virtual void Code(int yearExperience, string firstExtraDevLanguage){
            Console.WriteLine(String.Format("having {0} years of experience, I'm coding using my main Dev Language {1}. Additionaly, I'm using the {2} as extra de languages", yearExperience, this._mainDevLanguage, firstExtraDevLanguage));                    
        }

        /*
            Also this is what I meant when I said that a component can have the same form but different behavior
            so static polymorphism as we have mentioned that component is the method.
            So it is on a method level.

            You can have the same amount or different amount but different types of parameters and you can have
            the same amount or different amount but parameters put in a different order.

            So it's a three ways in which we can differentiate it.
            The amount to types and the order in which they're placed OK.      

            On the back end we're using static polymorphism in order to clean up our code.

        */
    }
}