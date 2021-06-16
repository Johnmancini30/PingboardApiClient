using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.Users.Requests
{
    /// <summary>
    /// Represents a User object
    /// </summary>
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;
        
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; } = null!;

        [JsonProperty("last_name")]
        public string LastName { get; set; } = null!;
        
        [JsonProperty("nickname")]
        public string? NickName { get; set; }
        
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }
        
        [JsonProperty("time_zone")]
        public string? TimeZone { get; set; }
        
        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("avatar_urls")]
        public Dictionary<string, string>? AvatarUrls { get; set; }
        
        [JsonProperty("avatar_original_size")]
        public List<int>? AvatarOriginalSize { get; set; }

        [JsonProperty("avatar_data")]
        public string? AvatarData { get; set; }

        [JsonProperty("job_title")]
        public string? JobTitle { get; set; }
        
        [JsonProperty("reports_to_id")]
        public int? ReportsToId { get; set; }

        [JsonProperty("bio")]
        public string? Bio { get; set; }
        
        [JsonProperty("phone")]
        public string? Phone { get; set; }
        
        [JsonProperty("skills")]
        public List<string>? Skills { get; set; }
        
        [JsonProperty("interests")]
        public List<string>? Interests { get; set; }
        
        [JsonProperty("custom_fields")]
        public Dictionary<string, string>? CustomFields { get; set; }
        
        [JsonProperty("roles")]
        public List<string>? Roles { get; set; }
        
        [JsonProperty("email_message_channel")]
        public bool EmailMessageChannel { get; set; }
        
        [JsonProperty("phone_message_channel")]
        public bool PhoneMessageChannel { get; set; }
    }
}
