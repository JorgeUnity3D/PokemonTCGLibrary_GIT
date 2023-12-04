﻿using System;
using Newtonsoft.Json;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.CommonModels
{
    public class Images
    {
        [JsonProperty("symbol")]
        public Uri Symbol { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }
    }
}