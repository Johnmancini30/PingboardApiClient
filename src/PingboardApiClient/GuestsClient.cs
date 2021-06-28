using System;
using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Internal.Queries;
using PingboardApiClient.Models.Guests.Requests;
using PingboardApiClient.Models.Guests.Responses;

namespace PingboardApiClient
{
    /// <summary>
    /// Used to query the Guests api
    /// </summary>
    public class GuestsClient
    {
        private readonly PingboardHttpFacade _httpFacade;
        private readonly GuestsQueryBuilder _queryBuilder;

        internal GuestsClient(
            PingboardHttpFacade httpFacade,
            GuestsQueryBuilder queryBuilder)
        {
            _httpFacade = httpFacade;
            _queryBuilder = queryBuilder;
        }

        /// <summary>
        /// returns all the guests
        /// </summary>
        public async Task<Guests> GetGuests(Action<GuestsQueryOptions>? options = null)
        {
            var queryOptions = new GuestsQueryOptions();
            options?.Invoke(queryOptions);

            var url = _queryBuilder.Build("api/v2/guests", queryOptions);
            return await _httpFacade.GetAsync<Guests>(url);
        }

        /// <summary>
        /// Given an id, returns the corresponding guest
        /// </summary>
        public async Task<Guests> GetGuest(int id)
        {
            return await _httpFacade.GetAsync<Guests>("api/v2/guests/{id}");
        }
    }
}
