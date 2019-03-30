using System.Collections.Generic;
using System.IO;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
            ReadTest();
        }
        static void ReadTest()
        {
            //path
            string path = "../../../../data.json";
            // instantiate serializer for use
            //JsonSerializer serializer = new JsonSerializer();
            //// open strem to file
            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    Console.WriteLine($"sw called: {path}");
            //}

            using (StreamReader reader = File.OpenText(path))
            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                // do stuff
                Console.WriteLine("reader form file");
            }



        }
    }
}
