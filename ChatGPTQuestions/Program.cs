/*
14. Working with Tuples
Question: Create a method that returns a tuple containing an integer, a string, and a boolean value. 
Call this method and destructure the tuple to access the individual values. 
 */

var(intResult, stringResult, boolResult) = GetMeSomeOThemValues();

Console.WriteLine($"intResult: {intResult}, stringResult: {stringResult}, boolResult: {boolResult}");


static (int, string, bool) GetMeSomeOThemValues()
{
    return (123, "HOORAY!!!", true);
}
