using System.Collections.Generic;
using System.Text.Json;
using TempleOfDoom.DAL;

namespace TempleOfDoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Pad naar het JSON-bestand
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DAL", "TempleOfDoom.json");
            // JSON-bestand inlezen
            string jsonString = File.ReadAllText(filePath);

            // Deserialiseren naar Rootobject
            JsonData.Rootobject data = JsonSerializer.Deserialize<JsonData.Rootobject>(jsonString);
        }
    }
}
