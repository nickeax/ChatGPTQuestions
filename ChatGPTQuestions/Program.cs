/*
 17. File Handling
Question: Write a program that reads a text file, counts the number of words in the file, and displays the result. 
Make sure to handle potential errors when the file is not found.
 */

using System.Text.RegularExpressions;

Console.WriteLine(WordCount(@"c:\tedsting", @"testData.txt"));

static int WordCount(string path, string fileName)
{
	try
	{
		if (Directory.Exists(path) && File.Exists(Path.Combine(path, fileName)))
		{
			var contents = File.ReadAllText(Path.Combine(path, fileName));

			return Regex.Matches(contents, @"\b\w+\b").Count;
		}
		else
		{
            Console.WriteLine("Error: File not found.");

			return -1;
		}

	}
	catch (Exception ex)
	{
        Console.WriteLine($"An error occured: {ex.Message}");

		return -1;
	}
}
