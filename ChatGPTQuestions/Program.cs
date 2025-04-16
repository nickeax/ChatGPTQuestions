/*
 15. Generics in C#
Question: Write a generic method Swap<T> that takes two parameters of type T and swaps their values. Test the method by swapping an integer and a string.
 */

int a = 123;
int b = 654;
string c = "First";
string d = "Second";

Console.WriteLine($"Before Swap");
Console.WriteLine($"a: {a}, b: {b}");

Swap(ref a, ref b);

Console.WriteLine($"After Swap");
Console.WriteLine($"a: {a}, b: {b}");

Console.WriteLine($"Before Swap");
Console.WriteLine($"c: {c}, d: {d}");

Swap(ref c, ref d);

Console.WriteLine($"After Swap");
Console.WriteLine($"c: {c}, d: {d}");

static void Swap<T>(ref T v1, ref T v2)
{
    var tmp = v1;
    v1 = v2;
    v2 = tmp;
}
