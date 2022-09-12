using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaOembedUrlResponse
{
	[JsonProperty("media_id")]
	public string MediaId { get; set; }
}
