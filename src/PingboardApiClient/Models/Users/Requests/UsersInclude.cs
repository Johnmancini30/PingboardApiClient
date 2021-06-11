namespace PingboardApiClient.Models.Users.Requests
{
    /// <summary>
    /// Enum for possible includes
    /// </summary>
    public enum UsersInclude
    {
        linked_accounts = 0,
        locations = 1,
        groups = 2,
        statuses = 3
    }
}
