using Newtonsoft.Json;
using System.Collections.Generic;
// https://www.newtonsoft.com/json/help/html/T_Newtonsoft_Json_Serialization_JsonProperty.htm

namespace LinqLab.Classes
{
    public class FeatureCollection
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Features")]
        public List<Feature> Features { get; set; }
    }
}