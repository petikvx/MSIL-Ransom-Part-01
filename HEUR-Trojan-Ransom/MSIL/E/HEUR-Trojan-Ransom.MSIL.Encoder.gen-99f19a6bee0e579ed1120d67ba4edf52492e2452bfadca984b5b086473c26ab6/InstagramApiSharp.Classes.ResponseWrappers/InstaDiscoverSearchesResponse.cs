using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaDiscoverSearchesResponse
{
	[JsonProperty("position")]
	public int Position { get; set; }

	[JsonProperty("user")]
	public InstaUserResponse User { get; set; }

	[JsonProperty("client_time")]
	public int? ClientTime { get; set; }
}
