using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Models.LinkedAccounts.Responses;

namespace PingboardApiClient
{
    /// <summary>
    /// client to hit LinkedAccounts api
    /// </summary>
    public class LinkedAccountsClient
    {
        private readonly PingboardHttpFacade _httpFacade;

        internal LinkedAccountsClient(PingboardHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }

        /// <summary>
        /// given an id returns the linked account related to it
        /// </summary>
        public async Task<LinkedAccounts> GetLinkedAccount(int id)
        {
            return await _httpFacade.GetAsync<LinkedAccounts>($"api/v2/linked_accounts/{id}");
        }
    }
}
