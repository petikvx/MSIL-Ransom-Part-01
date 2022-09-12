using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaAnimatedImageUserResponse
{
	[JsonProperty("is_verified")]
	public bool IsVerified { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }
}
