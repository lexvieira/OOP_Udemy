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
    }
}