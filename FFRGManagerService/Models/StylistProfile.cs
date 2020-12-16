using Newtonsoft.Json;

namespace FFRGManagerService.Models
{
    public class StylistProfile
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string GUID;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string LastName;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Salon;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float Latitude;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float Longitude;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string City;

        public StylistProfile()
        {
            this.GUID = "";
            this.FirstName = "";
            this.LastName = "";
            this.Salon = "";
            this.Latitude = 0;
            this.Longitude = 0;
            this.City = "";
        }

        public StylistProfile(string GUID, string FirstName, string LastName, string Salon, float Latitude, float Longitude, string City)
        {
            this.GUID = GUID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salon = Salon;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.City = City;
        }
    }
}
