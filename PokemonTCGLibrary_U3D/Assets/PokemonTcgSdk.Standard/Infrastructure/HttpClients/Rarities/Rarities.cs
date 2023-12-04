using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Rarities
{
    public class Rarities : ResourceBase
    {
        [JsonProperty("data")]
        public List<string> Rarity { get; set; }

        internal new static string ApiEndpoint { get; } = "rarities";

        public override string Id { get; set; }
    }
}