using Newtonsoft.Json;

namespace PingboardApiClient.Models.Groups.Requests
{
    /// <summary>
    /// Used to create a group
    /// Must include name, GroupsType
    /// </summary>
    public class CreateGroupRequest
    {
        public CreateGroupRequest(string name, GroupsType type)
        {
            Group.Name = name;
            Group.Type = type;
        }

        [JsonProperty("users")]
        public Group Group { get; } = new Group();
    }
}
