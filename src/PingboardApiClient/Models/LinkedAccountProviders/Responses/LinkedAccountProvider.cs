using Newtonsoft.Json;

namespace PingboardApiClient.Models.LinkedAccountProviders.Responses
{
    public class LinkedAccountProvider
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }
    }
}
