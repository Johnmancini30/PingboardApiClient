using System.Net.Http;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Internal.Queries;

namespace PingboardApiClient
{
    public class PingboardClient
    {
        private readonly PingboardHttpFacade _httpFacade;
        public UsersClient UsersClient { get; }

        public PingboardClient(string baseUrl, string clientId, string clientSecret, HttpClient? client = null)
        {
            _httpFacade = new PingboardHttpFacade(baseUrl, clientId, clientSecret, client);

            var usersQueryBuilder = new UsersQueryBuilder();
            UsersClient = new UsersClient(_httpFacade, usersQueryBuilder);
        }
    }
}
