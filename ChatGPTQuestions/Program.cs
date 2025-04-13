/*
 6. Using async and await
Question: Write an asynchronous method that downloads data from a URL and prints the first 100 characters. Use async and await keywords to implement this. 
Simulate a delay using Task.Delay if you don't actually want to make a network request.
 */

var res = (await GetNetworkWords());
Console.WriteLine(string.Join("", res.Take(100)));

async Task<string> GetNetworkWords()
{
    var res = string.Join("", (await Task.Run(() => Utils.Mocking.RandomWords(50, 3000))));
    
    return res;

}