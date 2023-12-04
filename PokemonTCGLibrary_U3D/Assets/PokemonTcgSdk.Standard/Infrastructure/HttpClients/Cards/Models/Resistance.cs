using Newtonsoft.Json;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models
{
    public class Resistance
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}