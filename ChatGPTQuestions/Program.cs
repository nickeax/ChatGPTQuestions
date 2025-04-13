/*
 12. Access Modifiers
Question: Create a class Person with private fields FirstName and LastName. 
Provide public methods to get and set these fields. 
Make sure to use the correct access modifiers and demonstrate how the access modifiers work.
 */

var p = new Person();

p.AccessFirstName = "Ken";
p.AccessLastName = "Carter";

Console.WriteLine($"Person.FirstName: {p.AccessFirstName}");
Console.WriteLine($"Person.LastName: {p.AccessLastName}");

public class Person
{
    string FirstName;
    string LastName;

    public string AccessFirstName { get => FirstName; set => FirstName = value ?? ""; }
    public string AccessLastName { get => LastName; set => LastName = value ?? ""; }
}