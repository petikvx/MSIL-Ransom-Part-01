using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaFormerUsernameInfoResponse
{
	[JsonProperty("has_former_usernames")]
	public bool? HasFormerUsernames { get; set; }
}
