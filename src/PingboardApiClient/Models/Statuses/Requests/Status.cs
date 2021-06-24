using System;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.Statuses.Requests
{
    /// <summary>
    /// Represents a Status object
    /// </summary>
    public class Status
    {
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        [JsonProperty("status_type_id")]
        public string? StatusTypeId { get; set; }

        [JsonProperty("all_day")]
        public bool AllDay { get; set; }

        [JsonProperty("starts_at")]
        public DateTime? StartsAt { get; set; }

        [JsonProperty("ends_at")]
        public DateTime? EndsAt { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("time_period")]
        public StatusesTimePeriod? TimePeriod { get; set; }

        [JsonProperty("links")]
        public StatusesLinks? Links { get; set; }

        public class StatusesLinks
        {
            [JsonProperty("status_type")]
            public string? StatusType { get; set; }

            [JsonProperty("user")]
            public string? User { get; set; }
        }
    }
}
