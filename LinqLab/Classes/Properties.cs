using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Text;

namespace LinqLab.Classes
{
    public class Properties
    {
        [JsonProperty("Zip")]
        public string zip { get; set; }

        [JsonProperty("City")]
        public string city { get; set; }

        [JsonProperty("State")]
        public string state { get; set; }

        [JsonProperty("Address")]
        public string address { get; set; }

        [JsonProperty("Borough")]
        public string borough { get; set; }

        [JsonProperty("Neighborhood")]
        public string neighborhood { get; set; }

        [JsonProperty("County")]
        public string county { get; set; }

    }
}