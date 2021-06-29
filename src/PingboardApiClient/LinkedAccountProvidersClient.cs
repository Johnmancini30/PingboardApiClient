using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Models.LinkedAccountProviders.Responses;

namespace PingboardApiClient
{
    /// <summary>
    /// Client for interacting with LinkedAccountProviders api
    /// </summary>
    public class LinkedAccountProvidersClient
    {
        private readonly PingboardHttpFacade _httpFacade;

        internal LinkedAccountProvidersClient(PingboardHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }

        /// <summary>
        /// gets LinkedAccountProviders
        /// </summary>
        public async Task<LinkedAccountProviders> GetLinkedAccountProviders()
        {
            return await _httpFacade.GetAsync<LinkedAccountProviders>("api/v2/linked_account_providers");
        }
    }
}
