using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsDaysHourlyFollowersGraphsResponse : InstaStatisticsDataPointsResponse
{
	[JsonProperty("name")]
	public string Name { get; set; }
}
