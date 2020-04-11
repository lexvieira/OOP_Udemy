git config --global user.email "lexvieira.info@gmail.com"
git config --global user.name "lexvieira"

https://www.youtube.com/watch?v=Fk12ELJ9Bww

https://code.visualstudio.com/docs/editor/versioncontrol

https://github.com/Microsoft/azure-repos-vscode/blob/master/TFVC_README.md#quick-start

git: updates were rejected because the remote contains work that you do not have locally
https://stackoverflow.com/questions/24357108/git-updates-were-rejected-because-the-remote-contains-work-that-you-do-not-have
git pull OOP_Udemy master:fstcm

git pull OOP_Udemy fstcm

SOLUTION
https://github.community/t5/How-to-use-Git-and-GitHub/How-to-deal-with-quot-refusing-to-merge-unrelated-histories-quot/m-p/16305#
git pull OOP_Udemy master:fstcm --allow-unrelated-histories


>> ABSTRACT CLASS 
https://www.udemy.com/course/beginner-object-oriented-programming-in-csharp-and-dotnet-core/learn/lecture/10716604#notes

>>>> 
One quick thing you might be wondering about is what happens when you have more parameters for the child
class that might not be going into a base class.
And the answer is we just don't pass it into the base class.
We set those in the child class.
An example would be H So if we have age or anything else in this case I just mentioned age.
So if we say in age and this doesn't really go anywhere but we needed for our child class then we would
>>>>

>>INTERFACES
https://www.udemy.com/course/beginner-object-oriented-programming-in-csharp-and-dotnet-core/learn/lecture/10716612#notes
>>>>
You can think of an interface as an abstract class that only has abstract methods and properties.
Interfaces do not have constructors or fields on them so they don't have a constructor.
They don't have fields.
>>>>
Now the question that might arise naturally is this Why in the world would we have interfaces if we
already have abstract classes then we can make them act as an interface.
This is an amazing question and one worth asking.
Also one quick invention you inherit from classes would you implement an interface.
Once again this is just a convention.
But at the end of the day it is just how you referred to an abstract class.
Inheritance versus interface inheritance.
But on the back end inheritance gets performed the same exact way for an abstract class or an interface
which is via a common symbol.
>>>>
But back to the question why do we have interfaces basically interfaces were made to get around the
lack of multiple inheritances in C sharp.
So that means that you cannot inherit from more than one class 
but you can implement multiple interfaces.
>>>>

>>>>
,SalesmanLittle
/*
    It says class car salesman cannot have multiple base classes.
    And that's because we cannot inherit from multiple classes.
*/

>>>> Abstract Classes vs Interfaces
As we saw in the previous videos some of the functionality as you know can be predefined and the rest
of it can be abstract or virtual.
It depends on the needs requirements etc. But that is the purpose of the abstract class.
We already know this part.
So this is just a refresher interfaces on the other hand are made to be completely abstract and their
purpose is to provide with an ability to unrelated group of classes.
>>>>
Interfaces When to use
And our salesman is an abstract class so we have came back to our original state that we started from.
But the reason why I wanted to do a quick rewrite is just to show you that it was not the correct tool
for our situation.
So that then we can see when is the right time to use an interface.



>>>> Polymorphism <<<<

>>>> End Static Polymorphism <<<<

>>>> Start Dynamic Polymorphism <<<<

>>>> Solving problems with Dynamic Polymorphism <<<<

>>>> Polymorphism using Interfaces <<<<




    