using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaInsightsDataNodeResponse
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("value")]
	public int? Value { get; set; }
}
