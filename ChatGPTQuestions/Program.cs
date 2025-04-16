/*
 16. String Manipulation
Question: Write a method that accepts a string and returns a new string with every alternate character capitalized. For example, "hello world" becomes "HeLlO WoRlD".
 */

using System.Text;

var output = CamelCase("The thin white camel is laughing...");
Console.WriteLine(output);

static string CamelCase(string input)
{
    var sb = new StringBuilder();
    
    for (int i = 0; i < input.Length; i++)
        if(i % 2 != 0)
            sb.Append($"{input[i]}".ToUpper());
        else
            sb.Append(input[i]);

    return sb.ToString();
}
