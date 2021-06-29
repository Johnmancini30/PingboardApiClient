using System;
using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Models.StatusTypes.Responses;

namespace PingboardApiClient
{
    /// <summary>
    /// client for interacting with StatusTypes api
    /// </summary>
    public class StatusTypesClient
    {
        private readonly PingboardHttpFacade _httpFacade;

        internal StatusTypesClient(PingboardHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }

        public async Task<StatusTypes> GetStatusTypes()
        {
            return await _httpFacade.GetAsync<StatusTypes>("api/v2/status_types");
        }
    }
}
