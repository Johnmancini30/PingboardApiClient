using System.Net.Http;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Internal.Queries;

namespace PingboardApiClient
{
    public class PingboardClient
    {
        private readonly PingboardHttpFacade _httpFacade;
        public UsersClient UsersClient { get; }
        public GroupsClient GroupsClient { get; }

        public PingboardClient(string baseUrl, string clientId, string clientSecret, HttpClient? client = null)
        {
            _httpFacade = new PingboardHttpFacade(baseUrl, clientId, clientSecret, client);

            var usersQueryBuilder = new UsersQueryBuilder();
            var groupsQueryBuilder = new GroupsQueryBuilder();
            UsersClient = new UsersClient(_httpFacade, usersQueryBuilder);
            GroupsClient = new GroupsClient(_httpFacade, groupsQueryBuilder);
        }
    }
}
