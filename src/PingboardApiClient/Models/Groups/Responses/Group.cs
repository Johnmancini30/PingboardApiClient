using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.Groups.Responses
{
    /// <summary>
    /// Represents a Group object
    /// </summary>
    public class Group
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("type")]
        public GroupsType Type { get; set; } = GroupsType.group;

        [JsonProperty("membership_count")]
        public int MembershipCount { get; set; } = 0;

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("custom_fields")]
        public Dictionary<string, string>? CustomFields { get; set; }

        [JsonProperty("logo_urls")]
        public Dictionary<string, string>? LogoUrls { get; set; }

        [JsonProperty("visible_to_owner")]
        public bool VisibleToOwner { get; set; }

        [JsonProperty("visible_to_group")]
        public bool VisibleToGroup { get; set; }

        [JsonProperty("visible_to_other")]
        public bool VisibleToOther { get; set; }

        [JsonProperty("editable_to_owner")]
        public bool EditableToOwner { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("latitude")]
        public int? Latitude { get; set; }

        [JsonProperty("longitude")]
        public int? Longitude { get; set; }

        [JsonProperty("links")]
        public GroupsLinks? Links { get; set; }

        public class GroupsLinks
        {
            [JsonProperty("users")]
            public List<string>? Users { get; set; }
        }
    }
}
