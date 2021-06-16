using Newtonsoft.Json;
using System.Collections.Generic;

namespace PingboardApiClient.Models.Groups.Responses
{
    public class Groups
    {
        [JsonProperty("groups")]
        public List<Group>? GroupList { get; set; }
    }
}
