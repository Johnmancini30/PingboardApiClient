using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.LinkedAccounts.Responses
{
    /// <summary>
    /// represents Linked Account object
    /// </summary>
    public class LinkedAccount
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("avatar_urls")]
        public Dictionary<string, string>? AvatarUrls { get; set; }

        [JsonProperty("linked_account_provider_id")]
        public string? LinkedAccountProviderId { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
