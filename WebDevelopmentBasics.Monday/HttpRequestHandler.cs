namespace WebDevelopmentBasics.Monday
{
    public class HttpRequestHandler
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task SendGetRequest(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            Console.WriteLine($"Status Code: {(int)response.StatusCode}");
        }

        public static async Task SendPostRequest(string url, string data)
        {
            HttpContent content = new StringContent(data);
            HttpResponseMessage response = await client.PostAsync(url, content);
            Console.WriteLine($"Status Code: {(int)response.StatusCode}");
        }
    }
}
