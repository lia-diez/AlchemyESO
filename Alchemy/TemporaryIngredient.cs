using System.Text.Json.Serialization;

namespace Alchemy;

public class TemporaryIngredient
{
    [JsonPropertyName("Reagent")]
    public string Reagent { get; set; }
    
    [JsonPropertyName("Primary Effect")]
    public string PrimaryEffect { get; set; }
    
    [JsonPropertyName("Secondary Effect")]
    public string SecondaryEffect { get; set; }
    
    [JsonPropertyName("Tertiary Effect")]
    public string TertiaryEffect { get; set; }
    
    [JsonPropertyName("Quaternary Effect")]
    public string QuaternaryEffect { get; set; }
    
    [JsonPropertyName("Comes from")]
    public string Comesfrom { get; set; }
}