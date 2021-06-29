using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.LinkedAccounts.Responses
{
    public class LinkedAccounts
    {
        [JsonProperty("linked_accounts")]
        public List<LinkedAccount>? LinkedAccountList { get; set; }
    }
}
