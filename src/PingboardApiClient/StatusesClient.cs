using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Models.Statuses.Responses;
using PingboardApiClient.Internal.Queries;
using PingboardApiClient.Models.Statuses.Requests;

namespace PingboardApiClient
{
    /// <summary>
    /// Used to query Pingboard Api statuses
    /// </summary>
    public class StatusesClient
    {
        private readonly PingboardHttpFacade _httpFacade;
        private readonly StatusesQueryBuilder _queryBuilder;

        internal StatusesClient(
            PingboardHttpFacade httpFacade,
            StatusesQueryBuilder queryBuilder)
        {
            _httpFacade = httpFacade;
            _queryBuilder = queryBuilder;
        }

        /// <summary>
        /// Gets all Statuses with optional query options
        /// </summary>
        public async Task<Statuses> GetStatusesAsync(Action<StatusesQueryOptions>? options = null)
        {
            var queryOptions = new StatusesQueryOptions();
            options?.Invoke(queryOptions);

            var url = _queryBuilder.Build("api/v2/statuses", queryOptions);
            return await _httpFacade.GetAsync<Statuses>(url);
        }

        /// <summary>
        /// Given an id will find the status matching it
        /// </summary>
        public async Task<Statuses> GetStatusAsync(int id, List<StatusesInclude>? includes = null)
        {
            var queryOptions = new StatusesQueryOptions() { Includes = includes };

            var url = _queryBuilder.Build($"api/v2/statuses/{id}", queryOptions);
            return await _httpFacade.GetAsync<Statuses>(url);
        }

        /// <summary>
        /// Given a status object, will create it
        /// </summary>
        public async Task<Statuses> CreateStatusAsync(CreateStatusRequest statusRequest)
        {
            return await _httpFacade.PostAsync<Statuses, CreateStatusRequest>($"api/v2/statuses", statusRequest);
        }

        /// <summary>
        /// Given a status object, will update it
        /// </summary>
        public async Task<Statuses> UpdateStatusAsync(int id, UpdateStatusRequest statusRequest)
        {
            return await _httpFacade.UpdateAsync<Statuses, UpdateStatusRequest>($"api/v2/statuses/{id}", statusRequest);
        }


        /// <summary>
        /// Given an id, will delete the status matching it
        /// </summary>
        public async Task DeleteStatusAsync(int id)
        {
            await _httpFacade.DeleteAsync($"api/v2/statuses/{id}");
        }
    }
}
