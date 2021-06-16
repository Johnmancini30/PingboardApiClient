using System.Linq;
using PingboardApiClient.Models.Groups.Requests;

namespace PingboardApiClient.Internal.Queries
{
    internal class GroupsQueryBuilder : QueryBuilder<GroupsQueryOptions>
    {
        protected override void BuildCore(Query query, GroupsQueryOptions options)
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

            if (options?.Name != null)
            {
                query.Add("name", options.Name);
            }

            if (options?.Type != null)
            {
                query.Add("type", options?.Type?.ToString() ?? string.Empty);
            }
        }
    }
}
