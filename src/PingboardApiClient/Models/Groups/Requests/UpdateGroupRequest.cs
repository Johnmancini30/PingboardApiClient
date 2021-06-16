using Newtonsoft.Json;

namespace PingboardApiClient.Models.Groups.Requests
{
    /// <summary>
    /// Used to update a group
    /// Must include name, GroupsType
    /// </summary>
    public class UpdateGroupRequest
    {
        public UpdateGroupRequest(string name, GroupsType type)
        {
            Group.Name = name;
            Group.Type = type;
        }

        [JsonProperty("users")]
        public Group Group { get; } = new Group();
    }
}
