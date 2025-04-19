/*
 20. Recursive Method
Question: Write a recursive method that calculates the factorial of a given number. For example, factorial(5) should return 120.
 */

int testNumber = 5;

Console.WriteLine(Factorial(testNumber));

static int Factorial(int input)
{
    if (input == 0)
        return 1;
    return input * Factorial(input - 1);
}
