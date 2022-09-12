using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHashtagStoryContainerResponse
{
	[JsonProperty("story")]
	public InstaHashtagStoryResponse Story { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
