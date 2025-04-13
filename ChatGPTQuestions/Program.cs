/*
 4. Inheritance and Polymorphism
Question: Create a class Animal with a method Speak(). Create two subclasses Dog and Cat that override the Speak() method. 
Create instances of Dog and Cat and call Speak() on each.
*/

var dog = new Dog();
var cat = new Cat();

Console.WriteLine(dog.Speak()); // Output: Woof!
Console.WriteLine(cat.Speak()); // Output: Meow!

public class Animal
{
    public virtual string Speak()
    {
        return "Animal speaks";
    }
}

public class Dog : Animal
{
    public override string Speak()
    {
        return "Woof!";
    }
}

public class Cat : Animal
{
    public override string Speak()
    {
        return "Meow!";
    }
}