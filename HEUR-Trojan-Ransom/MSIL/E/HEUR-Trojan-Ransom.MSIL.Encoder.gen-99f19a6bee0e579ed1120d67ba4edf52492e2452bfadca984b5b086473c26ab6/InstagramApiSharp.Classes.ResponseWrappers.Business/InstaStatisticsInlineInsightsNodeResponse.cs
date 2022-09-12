using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsInlineInsightsNodeResponse
{
	[JsonProperty("state")]
	public string State { get; set; }

	[JsonProperty("metrics")]
	public InstaStatisticsMetricsResponse Metrics { get; set; }
}
