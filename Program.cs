using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDeveloper mike = new WebDeveloper("Angular 6");
            mike.Code();
            mike.Code("C#");
            mike.Code("C#","HTML");
            mike.Code("HTML", 8);
            mike.Code(8, "VB");            

        }
    }
}

/*
    https://www.datacamp.com/community/tutorials/git-push-pull
*/
