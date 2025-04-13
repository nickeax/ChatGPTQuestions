/*
11. Interfaces and Implementations
Question: Define an interface IDriveable with a method Drive(). 
Create two classes, Car and Bike, that implement IDriveable and print a message in the Drive() method. 
Instantiate both and call Drive().
 */

var car = new Car();
var bike = new Bike();

car.Drive();
bike.Drive();

public interface IDriveable
{
    void Drive();
}

public class Car : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

public class Bike : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Bike is being ridden...");
    }
}