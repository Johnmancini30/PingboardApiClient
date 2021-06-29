using Newtonsoft.Json;

namespace PingboardApiClient.Models.StatusTypes.Responses
{
    /// <summary>
    /// represents status type object
    /// </summary>
    public class StatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("placeholder")]
        public string? Placeholder { get; set; }

        [JsonProperty("icon")]
        public string? Icon { get; set; }

        [JsonProperty("color")]
        public string? Color { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }
    }
}
