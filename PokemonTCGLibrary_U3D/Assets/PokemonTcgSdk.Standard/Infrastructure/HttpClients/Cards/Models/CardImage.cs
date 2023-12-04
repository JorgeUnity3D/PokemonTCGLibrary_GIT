using System;
using Newtonsoft.Json;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models
{
    public class CardImage
    {
        [JsonProperty("small")]
        public Uri Small { get; set; }

        [JsonProperty("large")]
        public Uri Large { get; set; }

    }
}