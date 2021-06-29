using System.Net.Http;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Internal.Queries;

namespace PingboardApiClient
{
    public class PingboardClient
    {
        private readonly PingboardHttpFacade _httpFacade;
        public CompanyClient Company { get; }
        public CustomFieldsClient CustomFields { get; set; }
        public GroupsClient Groups { get; }
        public GuestsClient Guests { get; }
        public LinkedAccountsClient LinkedAccounts { get; }
        public LinkedAccountProvidersClient LinkedAccountProviders { get; }
        public StatusesClient Statuses { get; }
        public StatusTypesClient StatusTypes { get; }
        public UsersClient Users { get; }

        public PingboardClient(string baseUrl, string clientId, string clientSecret, HttpClient? client = null)
        {
            _httpFacade = new PingboardHttpFacade(baseUrl, clientId, clientSecret, client);

            // setup query builders
            var groupsQueryBuilder = new GroupsQueryBuilder();
            var guestsQueryBuilder = new GuestsQueryBuilder();
            var statusesQueryBuilder = new StatusesQueryBuilder();
            var usersQueryBuilder = new UsersQueryBuilder();

            // initialize clients
            Company = new CompanyClient(_httpFacade);
            CustomFields = new CustomFieldsClient(_httpFacade);
            Groups = new GroupsClient(_httpFacade, groupsQueryBuilder);
            Guests = new GuestsClient(_httpFacade, guestsQueryBuilder);
            LinkedAccounts = new LinkedAccountsClient(_httpFacade);
            LinkedAccountProviders = new LinkedAccountProvidersClient(_httpFacade);
            Statuses = new StatusesClient(_httpFacade, statusesQueryBuilder);
            StatusTypes = new StatusTypesClient(_httpFacade);
            Users = new UsersClient(_httpFacade, usersQueryBuilder);
        }
    }
}
