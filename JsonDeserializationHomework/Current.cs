using System;

namespace JsonDeserializationHomework
{
    public class Current
    {
        public DateTime ObservationTime { get; set; }
        public int Temperature { get; set; }
        public int WeatherCode { get; set; }
        public string[] WeatherIcons { get; set; }
        public string[] WeatherDescriptions { get; set; }
        public int WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int Cloudcover { get; set; }
        public int Feelslike { get; set; }
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        public bool IsDay { get; set; }
    }
}
