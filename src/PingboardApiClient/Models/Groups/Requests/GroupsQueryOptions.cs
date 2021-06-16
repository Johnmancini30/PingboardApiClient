using System;
using System.Collections.Generic;

namespace PingboardApiClient.Models.Groups.Requests
{
    /// <summary>
    /// Query options for Groups api endpoint
    /// </summary>
    public class GroupsQueryOptions
    {
        /// <summary>
        /// Possible includes in the request, e.g. linked_accounts
        /// </summary>
        public List<GroupsInclude>? Includes { get; set; }

        /// <summary>
        /// Number of users to check per page. Default: 100
        /// </summary>
        public int PageSize { get; set; } = 100;

        /// <summary>
        /// Which page to get users from. Default: 1
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Possible sort key
        /// </summary>
        public GroupsSort? Sort { get; set; }

        /// <summary>
        /// Primary key to search for
        /// </summary>
        public List<int>? Ids { get; set; }

        /// <summary>
        /// Group Name to search for
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Group type to search for
        /// </summary>
        public GroupsType? Type { get; set; }
    }
}
