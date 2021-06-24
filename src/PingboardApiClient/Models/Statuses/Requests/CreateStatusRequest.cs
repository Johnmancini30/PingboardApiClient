using Newtonsoft.Json;

namespace PingboardApiClient.Models.Statuses.Requests
{
    public class CreateStatusRequest
    {
        [JsonProperty("status")]
        public Status Status { get; } = new Status();
    }
}
