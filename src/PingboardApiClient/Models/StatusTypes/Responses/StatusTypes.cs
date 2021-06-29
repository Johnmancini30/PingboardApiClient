using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.StatusTypes.Responses
{
    public class StatusTypes
    {
        [JsonProperty("status_types")]
        public List<StatusType>? StatusTypeList { get; set; }
    }
}
