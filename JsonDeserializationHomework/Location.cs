using System;

namespace JsonDeserializationHomework
{
    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string TimezoneId { get; set; }
        public DateTime Localtime { get; set; }
        public string LocaltimeEpoch { get; set; }
        public double UtcOffset { get; set; }
    }
}
