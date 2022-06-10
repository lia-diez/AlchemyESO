using System.Text.Json;
using Alchemy;

string jsonString = "";
using (var sr = new StreamReader(File.Open("../../../../alchemy.json", FileMode.Open)))
{
    string str = "";
    do
    {
        str = sr.ReadLine();
        jsonString += str + '\n';
    } while (str != null);
}

var temporary = JsonSerializer.Deserialize<List<TemporaryIngredient>>(jsonString);
var reagents = temporary.Select(a => new Ingredient(a)).ToList();

