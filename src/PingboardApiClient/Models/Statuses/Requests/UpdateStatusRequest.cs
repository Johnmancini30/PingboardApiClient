using Newtonsoft.Json;

namespace PingboardApiClient.Models.Statuses.Requests
{
    public class UpdateStatusRequest
    {
        [JsonProperty("status")]
        public Status Status { get; }  = new Status();
    }
}
