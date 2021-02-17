using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonDeserializationHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather;
            string jsonTextresult = File.ReadAllText("data.json");
            weather = JsonConvert.DeserializeObject<Weather>(jsonTextresult);

            Console.WriteLine($"Current-temperature:  {weather.Current.Temperature},  Request.Language: {weather.Request.Language}, Location.Lat: {weather.Location.Lat}");
        }
    }
}
