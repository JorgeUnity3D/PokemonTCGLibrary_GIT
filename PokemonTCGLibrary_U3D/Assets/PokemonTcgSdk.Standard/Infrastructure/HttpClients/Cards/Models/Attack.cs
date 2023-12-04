﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models
{
    public class Attack
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public List<string> Cost { get; set; }

        [JsonProperty("convertedEnergyCost")]
        public long ConvertedEnergyCost { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}