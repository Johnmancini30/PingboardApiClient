using Newtonsoft.Json;

namespace PingboardApiClient.Models.CustomFields.Requests
{
    public class UpdateCustomFieldRequest
    {
        [JsonProperty("custom_fields")]
        public CustomField CustomField { get; set; } = new CustomField();
    }
}
