using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsRootResponse
{
	[JsonProperty("data")]
	public InstaFullMediaInsightsDataResponse Data { get; set; }
}
