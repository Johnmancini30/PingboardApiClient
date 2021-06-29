using System.Collections.Generic;
using Newtonsoft.Json;

namespace PingboardApiClient.Models.LinkedAccountProviders.Responses
{
    public class LinkedAccountProviders
    {
        [JsonProperty("linked_account_providers")]
        public List<LinkedAccountProvider>? LinkedAccountProviderList { get; set; }
    }
}
