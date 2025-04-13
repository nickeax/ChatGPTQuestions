/*
 5. Working with Arrays
Question: Write a program that takes a 2D array of integers and finds the sum of all elements in the array. 
Make sure to iterate through the array properly.
 */

var testData = Utils.Mocking.GenerateRandomMultiDimensionalArray(5, 5);
int sum = 0;
int rows = testData.GetLength(0);
int cols = testData.GetLength(1);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
        sum += testData[i, j];
}

Console.WriteLine(sum);
