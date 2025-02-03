using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class CountryDataGenerator
    {
        public static async Task GenerateCountryDataFiles()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "https://restcountries.com/v3.1/all";
                    string response = await client.GetStringAsync(url);

                    using (JsonDocument doc = JsonDocument.Parse(response))
                    {
                        foreach (JsonElement element in doc.RootElement.EnumerateArray())
                        {
                            string name = element.GetProperty("name").GetProperty("common").GetString();
                            string region = element.GetProperty("region").GetString();
                            string subregion = element.TryGetProperty("subregion", out JsonElement subregionElement) ? subregionElement.GetString() : "N/A";
                            JsonElement latlng = element.GetProperty("latlng");
                            double area = element.GetProperty("area").GetDouble();
                            long population = element.GetProperty("population").GetInt64();

                            string fileName = $"{name}.txt";
                            string content = $"Region: {region}\nSubregion: {subregion}\nLatlng: {latlng}\nArea: {area}\nPopulation: {population}";

                            await File.WriteAllTextAsync(fileName, content);
                            Console.WriteLine($"File created: {fileName}");
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
        }
    }
}