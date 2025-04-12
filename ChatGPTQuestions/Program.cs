/*
 1. Using Delegates with LINQ
Question: Write a method that takes a list of integers and a delegate to filter out the even numbers. Use the delegate to remove even numbers from the list.
 */

var testData = Utils.Mocking.GenerateRandomInts(50).ToList();
var res = FilterByDelegate(testData, a => a % 2 == 0);

static List<int> FilterByDelegate(List<int> input, Func<int, bool> filter)
{
    return [.. input.Where(filter)];
}
