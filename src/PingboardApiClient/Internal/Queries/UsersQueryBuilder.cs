using System.Linq;
using PingboardApiClient.Models.Users.Requests;

namespace PingboardApiClient.Internal.Queries
{
    internal class UsersQueryBuilder : QueryBuilder<UsersQueryOptions>
    {
        protected override void BuildCore(Query query, UsersQueryOptions options)
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

            if (options?.Email != null)
            {
                query.Add("email", options.Email);
            }

            if (options?.FirstName != null)
            {
                query.Add("first_name", options.FirstName);
            }

            if (options?.LastName != null)
            {
                query.Add("last_name", options.LastName);
            }

            if (options?.StartDate != null)
            {
                query.Add("start_date", options.StartDate?.ToString() ?? string.Empty);
            }

            if (options?.JobTitle != null)
            {
                query.Add("job_title", options.JobTitle);
            }
        }
    }
}
