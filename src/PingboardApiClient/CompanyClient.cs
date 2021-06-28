using System;
using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Models.Company.Responses;

namespace PingboardApiClient
{
    /// <summary>
    /// Used to query Pingboard Api company
    /// </summary>
    public class CompanyClient
    {
        private readonly PingboardHttpFacade _httpFacade;

        internal CompanyClient(PingboardHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }

        /// <summary>
        /// requires company_admin
        /// </summary>
        public async Task<Companies> GetCompany()
        {
            return await _httpFacade.GetAsync<Companies>("/api/v2/companies");
        }
    }
}
