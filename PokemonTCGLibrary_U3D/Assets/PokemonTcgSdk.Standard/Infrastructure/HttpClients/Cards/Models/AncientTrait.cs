using Newtonsoft.Json;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models
{
    public class AncientTrait
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}