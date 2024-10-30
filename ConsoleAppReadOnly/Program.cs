
using Microsoft.IdentityModel.Clients.ActiveDirectory;

using System.Net;
/// <summary>
/// 
/// </summary>
class Program
{
    // Define your application credentials
    static string clientId = "your clientId";
    public static string authority = "https://login.microsoftonline.com/";
    static string clientSecret = "your clientSecret";
    static string resource = "api://"; // Replace with actual resource ID or endpoint

    static async Task Main(string[] args)
    {
        try
        {
            var token = await GetTokenAsync();
            Console.WriteLine("Access Token: " + token);
            await GetDataAsync(token);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }

    private static async Task PostDataAsync(string token)
    {
        HttpClient client = new HttpClient();
    }

    private static async Task GetDataAsync(string token)
    {
        HttpClient client = new();
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",token);
        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7097/WeatherForecast/GetWeatherForecast")
        {
            Content = new StringContent(String.Empty, System.Text.Encoding.UTF8, "application/json")
        };
        var response = await client.SendAsync(request); 

        var data = await response.Content.ReadAsStringAsync();

        Console.WriteLine(data);
    }

    static async Task<string> GetTokenAsync()
    {
        var context = new AuthenticationContext(authority);

        var clientCredential = new ClientCredential(clientId, clientSecret);

        var result = await context.AcquireTokenAsync(resource, clientCredential);

        return result.AccessToken;
    }
}
