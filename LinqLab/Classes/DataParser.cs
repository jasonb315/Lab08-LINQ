using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace LinqLab.Classes
{
    // entire parsed body
    public class Data
    {
        public string type { get; set; }
        public Feature[] features { get; set; }
    }
    
    // to Feature[]
    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    // to Feature
    public class Geometry
    {
        public string type { get; set; }
        public double[] coordinates { get; set; }
    }

    // to Feature
    public class Properties
    {
        public string zip { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public string borough { get; set; }
        public string neighborhood { get; set; }
        public string country { get; set; }

    }

}
