using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsImageResponse
{
	[JsonProperty("uri")]
	public string Uri { get; set; }
}
