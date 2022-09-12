using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsDataPointsDicoveryDailyNodesResponse
{
	[JsonProperty("nodes")]
	public InstaStatisticsDataPointsNodeResponse[] Nodes { get; set; }
}
