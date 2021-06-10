using PingboardApiClient.Internal.Http;

namespace PingboardApiClient
{
    /// <summary>
    /// Used to query Pingboard Api groups
    /// </summary>
    public class GroupsClient
    {
        private readonly PingboardHttpFacade _httpFacade;

        internal GroupsClient(PingboardHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }
        
        
    }
}
