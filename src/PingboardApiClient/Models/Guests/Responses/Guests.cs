using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.Guests.Responses
{
    public class Guests
    {
        [JsonProperty("guests")]
        public List<Guest>? GuestList { get; set; }
    }
}
