using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaRelatedHashtagResponse
{
	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }
}
