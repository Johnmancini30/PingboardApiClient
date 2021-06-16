using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Internal.Queries;
using PingboardApiClient.Models.Groups.Requests;
using PingboardApiClient.Models.Groups.Responses;

namespace PingboardApiClient
{
    /// <summary>
    /// Used to query Pingboard Api groups
    /// </summary>
    public class GroupsClient
    {
        private readonly PingboardHttpFacade _httpFacade;
        private readonly GroupsQueryBuilder _queryBuilder;

        internal GroupsClient(
            PingboardHttpFacade httpFacade,
            GroupsQueryBuilder queryBuilder)
        {
            _httpFacade = httpFacade;
            _queryBuilder = queryBuilder;
        }

        /// <summary>
        /// Gets all Groups with optional query options
        /// </summary>
        public async Task<Groups> GetGroupsAsync(Action<GroupsQueryOptions>? options = null)
        {
            var queryOptions = new GroupsQueryOptions();
            options?.Invoke(queryOptions);

            string url = _queryBuilder.Build("api/v2/groups", queryOptions);
            return await _httpFacade.GetAsync<Groups>(url);
        }

        /// <summary>
        /// Given an id will find the Group matching it
        /// </summary>
        public async Task<Groups> GetGroupAsync(int id, List<GroupsInclude>? includes = null)
        {
            var queryOptions = new GroupsQueryOptions() { Includes = includes };

            string url = _queryBuilder.Build($"api/v2/groups/{id}", queryOptions);
            return await _httpFacade.GetAsync<Groups>(url);
        }

        /// <summary>
        /// Given a Group object, will create it
        /// Requires company_admin acccess
        /// </summary>
        public async Task<Groups> CreateGroupAsync(CreateGroupRequest groupRequest)
        {
            return await _httpFacade.PostAsync<Groups, CreateGroupRequest>($"api/v2/groups", groupRequest);
        }

        /// <summary>
        /// Given a Group object, will update it
        /// Requires company_admin acccess
        /// </summary>
        public async Task<Groups> UpdateGroupAsync(int id, UpdateGroupRequest groupRequest)
        {
            return await _httpFacade.UpdateAsync<Groups, UpdateGroupRequest>($"api/v2/groups/{id}", groupRequest);
        }


        /// <summary>
        /// Given an id, will delete the group matching it
        /// Requires company_admin access
        /// </summary>
        public async Task DeleteGroupAsync(int id)
        {
            await _httpFacade.DeleteAsync($"api/v2/groups/{id}");
        }
    }
}
