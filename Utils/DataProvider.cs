namespace Utils;

public class DataProvider
{
    static public List<string> Words { get => $"Anna|Hello{new string("Hello".Reverse().ToArray())}|Given|a|list|of|integers|calculate|the|average|of|only|the|odd|numbers|using|LINQ|These|challenges|should|provide|a|good|opportunity|to|practice|LINQ|queries|while|also|keeping|them|small|enough|to|complete|quickly|in|LINQPad".Split('|').Distinct().ToList(); }
}
