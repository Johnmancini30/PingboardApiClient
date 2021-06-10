using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Models.Users.Responses;
using PingboardApiClient.Internal.Queries;
using PingboardApiClient.Models.Users.Requests;

namespace PingboardApiClient
{
    /// <summary>
    /// Used to hit the Users endpoint
    /// </summary>
    public class UsersClient
    {
        private readonly PingboardHttpFacade _httpFacade;
        private readonly UsersQueryBuilder _queryBuilder;

        internal UsersClient(
            PingboardHttpFacade httpFacade,
            UsersQueryBuilder queryBuilder)
        {
            _httpFacade = httpFacade;
            _queryBuilder = queryBuilder;
        }

        /// <summary>
        /// Gets all Users with optional query options
        /// </summary>
        public async Task<Users> GetUsersAsync(Action<UsersQueryOptions>? options = null)
        {
            var queryOptions = new UsersQueryOptions();
            options?.Invoke(queryOptions);

            string url = _queryBuilder.Build("api/v2/users", queryOptions);
            return await _httpFacade.GetAsync<Users>(url);
        }

        /// <summary>
        /// Given an id will find the user matching it
        /// </summary>
        public async Task<Users> GetUserAsync(int id, List<UsersInclude>? includes = null)
        {
            var queryOptions = new UsersQueryOptions() {Includes = includes};

            string url = _queryBuilder.Build($"api/v2/users/{id}", queryOptions);
            return await _httpFacade.GetAsync<Users>(url);
        }

        /// <summary>
        /// Given a user object, will create it
        /// </summary>
        public async Task<Users> CreateUserAsync(CreateUserRequest userRequest)
        {
            return await _httpFacade.PostAsync<Users, CreateUserRequest>($"api/v2/users", userRequest);
        }

        /// <summary>
        /// Given a user object, will update it
        /// </summary>
        public async Task<Users> UpdateUserAsync(int id, UpdateUserRequest userRequest)
        {
            return await _httpFacade.UpdateAsync<Users, UpdateUserRequest>($"api/v2/users/{id}", userRequest);
        }


        /// <summary>
        /// Given an id, will delete the user matching it
        /// </summary>
        public async Task DeleteUserAsync(int id)
        {
            await _httpFacade.DeleteAsync($"api/v2/users/{id}");
        }
    }
}
