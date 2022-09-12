using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsDataPointsNodeResponse : InstaStatisticsDataPointsResponse
{
	[JsonProperty("graph_name")]
	public string GraphName { get; set; }
}
