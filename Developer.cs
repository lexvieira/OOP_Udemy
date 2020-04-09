using System;
namespace OOP
{
    public class Developer
    {
        private string _mainDevLanguage;


        public Developer(string mainDevLanguage){
            this._mainDevLanguage = mainDevLanguage;
        }

        public virtual void Code(string firstExtraDevLanguage = null, string secondExtraDevLanguage = null){

            if (firstExtraDevLanguage == null && secondExtraDevLanguage == null){
                Console.WriteLine(String.Format("Hi, I'm coding using my main Dev Language {0}", this._mainDevLanguage));            
            }
            else if (firstExtraDevLanguage != null){
                Console.WriteLine(String.Format("I'm coding using my main Dev Language {0}. Additionaly, I'm using the {1} as extra de languages", this._mainDevLanguage, firstExtraDevLanguage));            
            }
            else if (secondExtraDevLanguage != null){
                Console.WriteLine(String.Format("I'm coding using my main Dev Language {0}. Additionaly, I'm using the {1} as extra de languages", this._mainDevLanguage, secondExtraDevLanguage));            
            }            
            else if (firstExtraDevLanguage != null && secondExtraDevLanguage != null){
                Console.WriteLine(String.Format("I'm coding using my main Dev Language {0}. Additionaly, I'm using the {1} and {2} as extra de languages", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));            
            }
            /*
                When you're mixing up the conditions it's very easy for this code to break.
                So if I was just some person and rewriting this thing and I wasn't very careful I could have easily broken the functionality.
            */

        }
    }
}