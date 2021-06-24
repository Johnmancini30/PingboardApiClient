using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.Statuses.Responses
{
    public class Statuses
    {
        [JsonProperty("statuses")]
        public List<Status>? StatusList { get; set; }
    }
}
