using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.Company.Responses
{
    /// <summary>
    /// Represents Company object
    /// </summary>
    public class Company
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("subdomain")]
        public string? Subdomain { get; set; }

        [JsonProperty("logo_urls")]
        public Dictionary<string, string>? LogoUrls { get; set; }

        [JsonProperty("contact_name")]
        public string? ContactName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("terminology")]
        public TerminologyMeta? Terminology { get; set; }

        [JsonProperty("theme")]
        public ThemeMeta? Theme { get; set; }


        public class TerminologyMeta
        {
            [JsonProperty("company")]
            public string? Company { get; set; }

            [JsonProperty("user")]
            public string? User { get; set; }

            [JsonProperty("guest")]
            public string? Guest { get; set; }

            [JsonProperty("group")]
            public string? Group { get; set; }

            [JsonProperty("location")]
            public string? Location { get; set; }
        }

        public class ThemeMeta
        {
            [JsonProperty("primary")]
            public string? Primary { get; set; }
        }
    }
}
