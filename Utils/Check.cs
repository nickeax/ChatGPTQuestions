namespace Utils;

public class Check
{
    public static bool IsPalindrome(string test)
    {
        return string.Equals(test, new string(test.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);
    }
    public static List<int> FindMissingElements(List<int> testList)
    {
        var ret = new List<int>();
        int? cachedElement = null;
        int? missing = null;
        foreach (var i in testList)
        {
            if (cachedElement != null)
            {
                var currentElement = cachedElement;
                var nextElement = i;

                missing = nextElement - cachedElement > 1 ? cachedElement + 1 : null;
                if (missing is not null) ret.Add(missing.Value);
            }
            cachedElement = i;
        }

        return ret;
    }
    public static bool IsAnagram(string first, string second)
    {
        if (!(first.Length == second.Length))
            return false;
        if (first.Sum(c => c) != second.Sum(c => c))
            return false;

        return first.Any(f => second.Contains(f));
    }
}




