using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum rpgClass
    {
        knights,
        Mage,
        Claric
    }
}
