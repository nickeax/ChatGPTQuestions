/*
 2. Lambda Expressions in C#
Question: Create a list of integers from 1 to 100. 
Use a lambda expression to filter the list to only include numbers divisible by 3 and 5, then calculate their sum.
 */

var testData = Enumerable.Range(1, 100);
var res = testData
    .Where(x => x % 3 == 0 && x % 5 == 0)
    .Sum();

Console.WriteLine("Sum of numbers divisible by 3 and 5 from 1 to 100: " + res);