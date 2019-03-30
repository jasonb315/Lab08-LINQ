using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using LinqLab.Classes;

namespace LinqLab
{
    //Create a program that brings in data from an external file, reads the data, and can filter the data based on specified values.

    //        Questions
    //-Each query builds off of the next.

    //Output all of the neighborhoods in this data list
    //Filter out all the neighborhoods that do not have any names
    //Remove the Duplicates
    //Rewrite the queries from above, and consolidate all into one single query.
    //Rewrite at least one of these questions only using the opposing method(example:
    //Use LINQ Query statements instead of LINQ method calls and vice versa.)

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataParser();
        }
        static void DataParser()
        {
            string path = "../../../../data.json";
            var json = File.ReadAllText(path);

            Console.WriteLine(json);

            ///


            var Data = JsonConvert.DeserializeObject<Data>(json);

            var allNeighborhood = Data.features.Select(x => x).Select(x => x.Properties).Select(x => x.neighborhood);

            foreach (var item in allNeighborhood)
            {
                Console.WriteLine(item);
            }

            //var deserializedData = JsonConvert.DeserializeObject<Classes.Data>(json);
            // Console.WriteLine(jason);
            // return deserializedData;
        }
            //path
            // instantiate serializer for use
            //JsonSerializer serializer = new JsonSerializer();
            //// open strem to file
            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    Console.WriteLine($"sw called: {path}");
            //}

            // using (StreamReader reader = File.OpenText(path))
            // {
            //     JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            //     // do stuff
            //     Console.WriteLine("reader form file");
            // }



        
    }
}
