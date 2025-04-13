/*
 8. Extension Methods
Question: Write an extension method for the string class that returns the string in reverse order. 
Then, use this method on a string object to print the reversed string.
 */

var testWord = "esreveR";
Console.WriteLine(testWord.NFReverse());

public static class StringExtentions
{
    public static string NFReverse(this string input)
    {
        return string.Join("", input.Reverse());
    }
}