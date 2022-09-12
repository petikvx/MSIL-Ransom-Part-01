using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryCTAContainerResponse
{
	[JsonProperty("links")]
	public InstaStoryCTAResponse[] Links { get; set; }
}
