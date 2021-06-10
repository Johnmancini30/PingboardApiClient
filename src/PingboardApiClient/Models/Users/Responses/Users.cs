using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.Users.Responses
{
    public class Users
    {
        [JsonProperty("users")]
        public List<User>? UserList { get; set; }
    }
}
