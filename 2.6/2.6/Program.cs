using System;
using System.Net;
using Newtonsoft.Json.Linq;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string apiKey = "6ec9abe8025c1c07a54f1a2bebd8c6a3";
        string city = "Tomsk";

        using (WebClient webClient = new WebClient())
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
            string response = await webClient.DownloadStringTaskAsync(url);

            var json = JObject.Parse(response);

            Console.WriteLine($"Weather Description: {json["weather"][0]["description"].Value<string>()}");
            Console.WriteLine($"Feels Like: {json["main"]["feels_like"].Value<double>()} °C");
            Console.WriteLine($"Wind Speed: {json["wind"]["speed"].Value<double>()} m/s");
            Console.WriteLine($"Temperature: {json["main"]["temp"].Value<double>()} °C");
        }
    }
}