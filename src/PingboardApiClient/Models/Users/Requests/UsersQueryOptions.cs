using System;
using System.Collections.Generic;
using System.Data;

namespace PingboardApiClient.Models.Users.Requests
{
    /// <summary>
    /// Query options for Users api endpoint
    /// </summary>
    public class UsersQueryOptions
    {
        /// <summary>
        /// Possible includes in the request, e.g. linked_accounts
        /// </summary>
        public List<UsersInclude>? Includes { get; set; }

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
        public UsersSort? Sort { get; set; }
        
        /// <summary>
        /// Primary key to search for
        /// </summary>
        public List<int>? Ids { get; set; }
        
        /// <summary>
        /// Email to search for
        /// </summary>
        public string? Email { get; set; }
        
        /// <summary>
        /// First name to look for
        /// </summary>
        public string? FirstName { get; set; }
        
        /// <summary>
        /// Last name to look for
        /// </summary>
        public string? LastName { get; set; }
        
        /// <summary>
        /// Start Date to look for
        /// </summary>
        public DateTime? StartDate { get; set; }
        
        /// <summary>
        /// Look for people of specific job
        /// </summary>
        public string? JobTitle { get; set; }
    }
}
