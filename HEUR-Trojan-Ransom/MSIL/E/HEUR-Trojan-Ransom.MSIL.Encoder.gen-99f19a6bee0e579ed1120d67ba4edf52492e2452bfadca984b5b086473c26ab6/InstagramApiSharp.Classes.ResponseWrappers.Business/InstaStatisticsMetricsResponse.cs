using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsMetricsResponse
{
	[JsonProperty("impressions")]
	public InstaStatisticsImpressionsResponse Impressions { get; set; }
}
