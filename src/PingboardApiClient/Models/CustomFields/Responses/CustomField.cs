using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.CustomFields.Responses
{
    public class CustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("visible_to_owner")]
        public bool VisibleToOwner { get; set; }

        [JsonProperty("visible_to_group")]
        public bool VisibleToGroup { get; set; }

        [JsonProperty("visible_to_other")]
        public bool VisibleToOther { get; set; }

        [JsonProperty("editable_by_owner")]
        public bool EditableByOwner { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("field_name")]
        public string? FieldName { get; set; }

        [JsonProperty("field_type")]
        public string? FieldType { get; set; }

        [JsonProperty("hint")]
        public string? Hint { get; set; }

        [JsonProperty("long")]
        public bool Long { get; set; }

        [JsonProperty("multiple")]
        public bool Multiple { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("sort_order_position")]
        public int SortOrderPosition { get; set; }

        [JsonProperty("valid_values")]
        public List<string>? ValidValues { get; set; }

        [JsonProperty("standard")]
        public bool Standard { get; set; }

        [JsonProperty("locked_fields")]
        public List<string>? LockedFields { get; set; }
    }
}
