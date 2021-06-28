using System;
using System.Collections.Generic;

namespace PingboardApiClient.Models.Guests.Requests
{
    /// <summary>
    /// Query options for the guests endpoint
    /// </summary>
    public class GuestsQueryOptions
    {
        /// <summary>
        /// Number of users to check per page. Default: 100
        /// </summary>
        public int PageSize { get; set; } = 100;

        /// <summary>
        /// Which page to get users from. Default: 1
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Possible sort keys
        /// </summary>
        public List<GuestsSort>? GuestsSort { get; set; }

        /// <summary>
        /// filters for Guests created after given date
        /// </summary>
        public DateTime? CreatedAt { get; set; }
    }
}
