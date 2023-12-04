using PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards;
using System;

namespace PokemonTcgSdk.Standard.Features.FilterBuilder.Energy
{
    public static class EnergyFilter
    {
        public static EnergyFilterCollection<string, string> AddId(this EnergyFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(EnergyCard.Id).ToLower(), value);
        }

        public static EnergyFilterCollection<string, string> AddName(this EnergyFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(EnergyCard.Name).ToLower(), value);
        }

        public static EnergyFilterCollection<string, string> AddSubTypes(this EnergyFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(EnergyCard.Subtypes).ToLower(), value);
        }

        public static EnergyFilterCollection<string, string> AddSetName(this EnergyFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, $"{nameof(EnergyCard.Set).ToLower()}.{nameof(EnergyCard.Set.Name).ToLower()}", value);
        }

        public static EnergyFilterCollection<string, string> AddSetSeries(this EnergyFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, $"{nameof(EnergyCard.Set).ToLower()}.{nameof(EnergyCard.Set.Series).ToLower()}", value);
        }

        public static EnergyFilterCollection<string, string> AddRarity(this EnergyFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(EnergyCard.Rarity).ToLower(), value);
        }

        private static EnergyFilterCollection<string, string> AddOrUpdate(EnergyFilterCollection<string, string> dictionary, string key, string value)
        {
            if (dictionary.TryGetValue(key, out var oldValue))
            {
                oldValue = $"{oldValue},{value}";
                dictionary[key] = oldValue;
                return dictionary;
            }

            dictionary.Add(key, value);
            return dictionary;
        }
    }
}