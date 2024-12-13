using System.Text.Json;
using System.Xml.Linq;
using TempleOfDoom.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TempleOfDoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Path naar je JSON-bestand
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DAL", "TempleOfDoom.json");

            // Lees de inhoud van het JSON-bestand
            string jsonString = File.ReadAllText(filePath);

            // Deserialize JSON naar een object
            JsonDataObjects.GameData myData = JsonSerializer.Deserialize<JsonDataObjects.GameData>(jsonString);
            Console.WriteLine(myData.player.startRoomId);


        }
    }
}
