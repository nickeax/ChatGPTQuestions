namespace Utils;
public class Log
{
    // Print collection if passed in
    public static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
    /// Print collection if passed in
    public static void PrintCollection<T>(IEnumerable<T> collection, string message)
    {
        Console.WriteLine(message);
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
    // Print message
    public static void Print(string message)
    {
        Console.WriteLine(message);
    }
    // Print message with color
    public static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    // Print message with color and background color
    public static void Print(string message, ConsoleColor color, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = color;
        Console.BackgroundColor = backgroundColor;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    // Print message with color and background color
    public static void Print(string message, ConsoleColor color, ConsoleColor backgroundColor, bool bold)
    {
        if (bold)
        {
            Console.WriteLine("\u001b[1m" + message + "\u001b[0m");
        }
        else
        {
            Console.WriteLine(message);
        }
        Console.ForegroundColor = color;
        Console.BackgroundColor = backgroundColor;
        Console.ResetColor();
    }
    // Print message with color and background color
    public static void Print(string message, ConsoleColor color, ConsoleColor backgroundColor, bool bold, bool underline)
    {
        if (bold)
        {
            Console.WriteLine("\u001b[1m" + message + "\u001b[0m");
        }
        else
        {
            Console.WriteLine(message);
        }
        if (underline)
        {
            Console.WriteLine("\u001b[4m" + message + "\u001b[0m");
        }
        Console.ForegroundColor = color;
        Console.BackgroundColor = backgroundColor;
        Console.ResetColor();
    }
    // Use reflection to print all user defined properties of an object
    public static void PrintProperties(object obj)
    {
        var properties = obj.GetType().GetProperties();
        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            Console.WriteLine($"{property.Name}: {value}");
        }
    }
    // Use reflection to print all user defined properties of an object
    public static void PrintProperties(object obj, string message)
    {
        Console.WriteLine(message);
        var properties = obj.GetType().GetProperties();
        foreach (var property in properties)
        { 
            var value = property.GetValue(obj);
            Console.WriteLine($"{property.Name}: {value}");
        }
    }
    // Use reflection to print all user defined properties of an object in formatted columns
    // 
    public static void PrintPropertiesInColumns(object obj, int columnWidth)
    {
        var properties = obj.GetType().GetProperties();
        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            Console.WriteLine($"{property.Name,{columnWidth}}: {value}");
        }
    }
}
