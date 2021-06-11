using Newtonsoft.Json;

namespace PingboardApiClient.Models.Users.Requests
{
    /// <summary>
    /// Used to update a user
    /// Must include firstName, lastName, email
    /// </summary>
    public class UpdateUserRequest
    {
        public UpdateUserRequest(string firstName, string lastName, string email)
        {
            User.FirstName = firstName;
            User.LastName = lastName;
            User.Email = email;
        }

        [JsonProperty("users")] 
        public User User { get; } = new User();
    }
}
