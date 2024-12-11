using Newtonsoft.Json;

namespace WebDevelopmentAndAPI.FourhDay
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.restful-api.dev/objects");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                List<Phone>? phones = JsonConvert.DeserializeObject<List<Phone>>(responseBody);

                if (phones != null)
                {
                    foreach (var phone in phones)
                    {
                        if (phone.Name != null)
                            Console.WriteLine(phone.Name);
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
