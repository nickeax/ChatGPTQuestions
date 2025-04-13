/*
 7. LINQ Query Syntax vs Method Syntax
Question: Given a list of strings, use both LINQ query syntax and method syntax to find all strings that start with the letter "A". 
Compare the two approaches and explain the difference.
 */

var testData = Utils.Mocking.RandomWords(50);

var querySyntaxResults = from word in testData where word[0] == 'A' select word;
var queryResult = testData.Where(x => x[0] == 'A');

foreach (var result in querySyntaxResults)
    Console.WriteLine(result);

foreach (var result in queryResult)
    Console.WriteLine(result);

/*
 The Differences:
 - LINQ syntax requires an explicit Select call and the syntax is similiar to SQL
 - Method syntax is plain C# code and is more appealing to me because I don't need to change my thought paradigm to use it
 */