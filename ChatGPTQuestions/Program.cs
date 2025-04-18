/*
 19. Nullable Types
Question: Write a program that demonstrates the use of nullable types in C#. 
Create a nullable int and assign it both a value and null. 
Then, display its value and check if it has a value using HasValue.
 */

int? nullableInt1 = 123;
DisplayValue(nullableInt1);
nullableInt1 = null;
DisplayValue(nullableInt1);

static void DisplayValue(int? input)
{
    if (input.HasValue)
    {
        Console.WriteLine($"The input has a value of: {input}");
    }
    else
    {
        Console.WriteLine("The input is null.");
    }
}
