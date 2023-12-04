using PokemonTcgSdk.Standard.Infrastructure.HttpClients.Set;

namespace PokemonTcgSdk.Standard.Features.FilterBuilder.Set
{
    // TODO: Legalities Filters
    public static class SetFilter
    {
        /// <summary>
        /// Extension method. Will add new Set id filter. If id filter exists
        /// will be concatenation and create an OR filter. e.g "dp4-3" or "dp4-4"
        /// </summary>
        /// <param name="dictionary">Filter dictionary</param>
        /// <param name="value">The id value to add</param>
        public static SetFilterCollection<string, string> AddId(this SetFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(Set.Id).ToLower(), value);
        }

        /// <summary>
        /// Extension method. Will add new Set name filter. If name filter exists
        /// will be concatenation and create an OR filter. e.g "XY" or "SM"
        /// </summary>
        /// <param name="dictionary">Filter dictionary</param>
        /// <param name="value">The name value to add</param>
        public static SetFilterCollection<string, string> AddName(this SetFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(Set.Name), value);
        }

        /// <summary>
        /// Extension method - Will add new Set series filter. If series filter exists,
        /// will concatenate and create an OR filter. e.g "Base" or "Sun & Moon"
        /// </summary>
        /// <param name="dictionary">Filter dictionary</param>
        /// <param name="value">The series value to add</param>
        public static SetFilterCollection<string, string> AddSeries(this SetFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(Set.Series), value);
        }

        /// <summary>
        /// Extension method - Will add new Set PtcgoCode filter (i.e. online code for the Set). If PtcgoCode already exists
        /// in the filter will concatenate and create an OR filter. e.g "PR-SM" or "XY"
        /// </summary>
        /// <param name="dictionary">Filter dictionary</param>
        /// <param name="value">The PTCGO Code value to add</param>
        public static SetFilterCollection<string, string> AddPtcgoCode(this SetFilterCollection<string, string> dictionary, string value)
        {
            return AddOrUpdate(dictionary, nameof(Set.PtcgoCode), value);
        }

        private static SetFilterCollection<string, string> AddOrUpdate(SetFilterCollection<string, string> dictionary, string key, string value)
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