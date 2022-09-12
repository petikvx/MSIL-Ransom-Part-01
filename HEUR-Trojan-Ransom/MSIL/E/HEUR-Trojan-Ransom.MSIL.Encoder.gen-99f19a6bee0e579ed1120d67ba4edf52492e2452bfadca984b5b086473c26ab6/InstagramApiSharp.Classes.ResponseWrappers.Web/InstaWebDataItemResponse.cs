using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Web;

public class InstaWebDataItemResponse
{
	[JsonProperty("text")]
	public string Text { get; set; }

	[JsonProperty("timestamp")]
	public long? Timestamp { get; set; }
}
