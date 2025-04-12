public class Log
{
    public static void PrintCollectionInColumns<T>(IEnumerable<T> collection, int columnWidth = 20, ConsoleColor propertyColor = ConsoleColor.Cyan, ConsoleColor valueColor = ConsoleColor.White)
    {
        foreach (var obj in collection)
        {
            PrintObjectPropertiesInColumns(obj, columnWidth, propertyColor, valueColor);
        }
    }

    private static void PrintObjectPropertiesInColumns<T>(T obj, int columnWidth, ConsoleColor propertyColor, ConsoleColor valueColor)
    {
        var properties = obj.GetType().GetProperties();

        // Print the properties and their values in columns with colorization
        foreach (var property in properties)
        {
            var value = property.GetValue(obj);

            // Set color for property name
            Console.ForegroundColor = propertyColor;
            Console.Write("{0,-" + columnWidth + "}: ", property.Name);

            // Set color for property value
            Console.ForegroundColor = valueColor;
            Console.WriteLine(value);

            // Reset to default color after printing the value
            Console.ResetColor();
        }
        Console.WriteLine(); // Add an empty line between objects
    }
}
