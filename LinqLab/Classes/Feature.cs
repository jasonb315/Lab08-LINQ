using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Text;

namespace LinqLab.Classes
{
    public class Feature
    {
        [JsonProperty("Type")]
        public string type { get; set; }

        [JsonProperty("Properties")]
        public Properties Properties { get; set; }
    }

}