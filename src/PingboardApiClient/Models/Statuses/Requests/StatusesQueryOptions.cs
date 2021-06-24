using System;
using System.Collections.Generic;

namespace PingboardApiClient.Models.Statuses.Requests
{
    /// <summary>
    /// Query options for Statuses api endpoint
    /// </summary>
    public class StatusesQueryOptions
    {
        /// <summary>
        /// which links to include
        /// </summary>
        public List<StatusesInclude>? Includes { get; set; }

        /// <summary>
        /// number of entries per page
        /// </summary>
        public int PageSize { get; set; } = 100;

        /// <summary>
        /// page number
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Primary key of statuses
        /// </summary>
        public List<int>? Ids { get; set; }

        /// <summary>
        /// user id to get statuses for
        /// </summary>
        public string? UserID { get; set; }

        /// <summary>
        /// start date of statuses filter
        /// </summary>
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// end date of statuses filter
        /// </summary>
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// which value to sort by
        /// </summary>
        public StatusesSort? Sort { get; set; }
    }
}
