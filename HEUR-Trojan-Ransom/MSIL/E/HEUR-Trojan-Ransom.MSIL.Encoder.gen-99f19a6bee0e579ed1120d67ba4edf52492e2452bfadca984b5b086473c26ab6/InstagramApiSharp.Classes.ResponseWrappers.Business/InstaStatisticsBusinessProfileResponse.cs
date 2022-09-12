using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsBusinessProfileResponse
{
	[JsonProperty("id")]
	public string Id { get; set; }
}
