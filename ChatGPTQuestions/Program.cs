/*
 3. Custom Exception Handling
Question: Write a custom exception class called NegativeNumberException that is thrown 
if a negative number is passed into a method that accepts only positive integers. 
Handle the exception using a try-catch block.
 */

var numberChecker = new SimpleNumberChecker();

try
{
    Console.WriteLine("Enter a positive number:");
    int number = int.Parse(Console.ReadLine());
    numberChecker.CheckPositiveNumber(number);
    Console.WriteLine($"You entered a valid positive number: {number}");
}
catch (NegativeNumberException ex)
{
    Console.WriteLine(ex.Message);
}

public class SimpleNumberChecker
{
    public int CheckPositiveNumber(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException($"You're an idiot, you tried to pass a negative number into a method that only accepts positive numbers: {number} is not positive.");
        }

        return number;
    }
}

public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {

    }
}
