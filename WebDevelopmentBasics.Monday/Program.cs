namespace WebDevelopmentBasics.Monday
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "example.ru";
            await HttpRequestHandler.SendGetRequest(url);
            await HttpRequestHandler.SendPostRequest(url, string.Empty);

        }
    }
}
