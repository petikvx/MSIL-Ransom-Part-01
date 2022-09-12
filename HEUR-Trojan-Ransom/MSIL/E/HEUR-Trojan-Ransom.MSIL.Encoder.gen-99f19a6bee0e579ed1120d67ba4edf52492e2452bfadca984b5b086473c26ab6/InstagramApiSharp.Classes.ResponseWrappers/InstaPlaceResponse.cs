using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaPlaceResponse
{
	[JsonProperty("location")]
	public InstaPlaceShortResponse Location { get; set; }

	[JsonProperty("title")]
	public string Title { get; set; }

	[JsonProperty("subtitle")]
	public string Subtitle { get; set; }
}
