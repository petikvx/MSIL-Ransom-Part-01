using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaMerchantResponse
{
	[JsonProperty("pk")]
	public long Pk { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }

	[JsonProperty("profile_pic_url")]
	public string ProfilePicture { get; set; }
}
