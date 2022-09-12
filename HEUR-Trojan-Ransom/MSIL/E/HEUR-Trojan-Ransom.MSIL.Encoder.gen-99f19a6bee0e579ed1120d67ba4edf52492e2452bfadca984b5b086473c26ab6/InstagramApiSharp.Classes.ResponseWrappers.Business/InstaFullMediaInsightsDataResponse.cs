using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsDataResponse
{
	[JsonProperty("media")]
	public InstaFullMediaInsightsResponse Media { get; set; }
}
