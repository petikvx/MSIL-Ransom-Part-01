using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsDataPointsDailyNodesResponse
{
	[JsonProperty("total_count_graph")]
	public InstaStatisticsDataPointsNodeResponse TotalCountGraph { get; set; }
}
