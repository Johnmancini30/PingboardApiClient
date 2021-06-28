using System.Linq;
using PingboardApiClient.Models.Guests.Requests;

namespace PingboardApiClient.Internal.Queries
{
    internal class GuestsQueryBuilder : QueryBuilder<GuestsQueryOptions>
    {
        protected override void BuildCore(Query query, GuestsQueryOptions options)
        {
            query.Add("page_size", options.PageSize);
            query.Add("page", options.Page);

            if (options.GuestsSort?.Any() ?? false)
            {
                query.Add("sort", options.GuestsSort.Select(sort => sort.ToString()).ToList());
            }

            if (options.CreatedAt != null)
            {
                query.Add("created_at", options.CreatedAt?.ToString() ?? string.Empty);
            }
        }
    }
}
