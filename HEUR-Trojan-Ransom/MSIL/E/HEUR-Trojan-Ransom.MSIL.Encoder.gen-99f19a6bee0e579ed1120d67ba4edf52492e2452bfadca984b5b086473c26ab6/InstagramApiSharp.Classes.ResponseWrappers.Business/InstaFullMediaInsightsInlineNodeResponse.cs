using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsInlineNodeResponse
{
	[JsonProperty("state")]
	public string State { get; set; }

	[JsonProperty("metrics")]
	public InstaFullMediaInsightsMetricsResponse Metrics { get; set; }
}
