namespace Utils;
public class Mocking
{
    static Random rnd = new();
    public static IEnumerable<int> GenerateRandomInts(int cnt)
    {
        for (int i = 0; i < cnt; i++)
            yield return rnd.Next(100);
    }
    public static int[,] GenerateRandomMultiDimensionalArray(int rows, int cols)
    {
        var ret = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                ret[i, j] = rnd.Next(100);
            }
        }
        return ret;
    }
    public static List<List<int>> BuildListOfList(int rows, int maxElements)
    {
        var ret = new List<List<int>>();
        for (int i = 0; i < rows; i++)
        {
            ret.Add([.. GenerateRandomInts(maxElements)]);
        }

        return ret;
    }
    public static List<T> Flatten<T>(List<List<T>> input)
    {
        return [.. input.SelectMany(i => i)];
    }
    public static string RandomWord => DataProvider.Words[rnd.Next(DataProvider.Words.Count - 1)];
    public static List<string> RandomWords(int cnt)
    {
        var ret = new List<string>();
        for (int i = 0; i < cnt; i++)
        {
            ret.Add(RandomWord);
        }

        return ret;
    }
    public static List<string> RandomWords(int cnt, int mockNetworkDelay)
    {
        Thread.Sleep(mockNetworkDelay);

        return RandomWords(cnt);
    }

    public static List<string> CreatePairs(int cnt)
    {
        var ret = new List<string>();
        for (int i = 0; i < cnt; i++)
        {
            var randomKey = RandomWord;
            if (ret.Where(x => x.Split('=')[0].Equals(randomKey, StringComparison.OrdinalIgnoreCase)).Count() == 0)
                ret.Add($"{randomKey}={RandomWord}");
        }

        return ret;
    }
}
