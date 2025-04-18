/*
18. DateTime Manipulation
Question: Write a method that calculates the number of days between two DateTime objects. The method should take two dates as input and return the difference in days. 
 */

Console.WriteLine(DateDifference(DateTime.Now.AddDays(-15), DateTime.Now)); 

static int DateDifference(DateTime begin, DateTime end)
{
    return (end - begin).Days;
}
