using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryTalliesItemResponse
{
	[JsonProperty("text")]
	public string Text { get; set; }

	[JsonProperty("font_size")]
	public float FontSize { get; set; }

	[JsonProperty("count")]
	public int Count { get; set; }
}
