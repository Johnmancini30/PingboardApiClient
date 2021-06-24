using System.Linq;
using PingboardApiClient.Models.Statuses.Requests;

namespace PingboardApiClient.Internal.Queries
{
    internal class StatusesQueryBuilder : QueryBuilder<StatusesQueryOptions>
    {
        protected override void BuildCore(Query query, StatusesQueryOptions options)
        {
            query.Add("page_size", options.PageSize);
            query.Add("page", options.Page);

            if (options?.Includes?.Any() ?? false)
            {
                query.Add("include", options.Includes.Select(include => include.ToString()).ToList());
            }

            if (options?.Sort != null)
            {
                query.Add("sort", options.Sort?.ToString() ?? string.Empty);
            }

            if (options?.Ids?.Any() ?? false)
            {
                query.Add("id", options.Ids);
            }

            if (options?.UserID != null)
            {
                query.Add("user_id", options.UserID);
            }

            if (options?.StartsAt != null)
            {
                query.Add("starts_at", options.StartsAt.ToString() ?? string.Empty);
            }

            if (options?.EndsAt != null)
            {
                query.Add("ends_at", options.EndsAt.ToString() ?? string.Empty);
            }
        }
    }
}
