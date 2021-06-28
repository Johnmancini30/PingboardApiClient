using Newtonsoft.Json;
using System;

namespace PingboardApiClient.Models.Guests.Responses
{
    /// <summary>
    /// represents Guest object
    /// </summary>
    public class Guest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }

        [JsonProperty("country_of_origin")]
        public string? CountryOfOrigin { get; set; }

        [JsonProperty("reason_for_visit")]
        public string? ReasonForVisit { get; set; }
    }
}
