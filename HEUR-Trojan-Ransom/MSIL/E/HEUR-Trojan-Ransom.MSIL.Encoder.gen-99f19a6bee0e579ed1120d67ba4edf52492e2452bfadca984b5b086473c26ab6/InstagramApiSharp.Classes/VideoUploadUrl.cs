using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class VideoUploadUrl
{
	[JsonProperty("url")]
	public string Url { get; set; }

	[JsonProperty("job")]
	public string Job { get; set; }

	[JsonProperty("expires")]
	public double Expires { get; set; }
}
