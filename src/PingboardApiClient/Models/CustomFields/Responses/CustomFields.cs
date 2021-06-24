using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.CustomFields.Responses
{
    public class CustomFields
    {
        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFieldList { get; set; }
    }
}
