// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var greeting = FetchGreeting();
            var planet = FetchPlanet();

            Console.WriteLine($"{greeting}, {planet}!");
            Thread.Sleep(2000);
        }
    }

    private static string FetchGreeting()
    {
        var http = new HttpClient();
        http.BaseAddress = new Uri("http://greeting-service/Greeting");
        
        var response = http.Send(new HttpRequestMessage() { Method = HttpMethod.Get });
        var contentTask = response.Content.ReadAsStringAsync();
        contentTask.Wait();
        return contentTask.Result;
    }

    private static string FetchPlanet()
    {
        var http = new HttpClient();
        http.BaseAddress = new Uri("http://planet-service/Planet");
        
        var response = http.Send(new HttpRequestMessage() { Method = HttpMethod.Get });
        var contentTask = response.Content.ReadAsStringAsync();
        contentTask.Wait();
        return contentTask.Result;
    }
}