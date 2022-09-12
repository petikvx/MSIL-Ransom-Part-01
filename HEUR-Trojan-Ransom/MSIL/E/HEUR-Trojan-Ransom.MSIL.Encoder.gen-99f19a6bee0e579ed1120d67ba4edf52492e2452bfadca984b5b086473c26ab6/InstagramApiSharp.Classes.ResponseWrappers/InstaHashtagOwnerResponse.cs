using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHashtagOwnerResponse
{
	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("pk")]
	public string Pk { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("profile_pic_url")]
	public string ProfilePicUrl { get; set; }

	[JsonProperty("profile_pic_username")]
	public string ProfilePicUsername { get; set; }
}
