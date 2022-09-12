using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Web;

public class InstaWebDataResponse
{
	[JsonProperty("link")]
	public object Link { get; set; }

	[JsonProperty("data")]
	public InstaWebDataItemResponse Data { get; set; }

	[JsonProperty("cursor")]
	public string Cursor { get; set; }
}
