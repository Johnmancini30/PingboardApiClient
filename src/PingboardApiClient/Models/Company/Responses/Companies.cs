using Newtonsoft.Json;
using System.Collections.Generic;

namespace PingboardApiClient.Models.Company.Responses
{
    public class Companies
    {
        [JsonProperty("companies")]
        public List<Company>? CompanyList { get; set; }
    }
}
