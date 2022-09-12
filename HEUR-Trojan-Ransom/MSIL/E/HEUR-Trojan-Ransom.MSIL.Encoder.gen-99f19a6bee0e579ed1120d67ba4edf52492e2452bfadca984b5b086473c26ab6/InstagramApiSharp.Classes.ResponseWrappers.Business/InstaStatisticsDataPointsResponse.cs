using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsDataPointsResponse
{
	[JsonProperty("data_points")]
	public InstaStatisticsDataPointItemResponse[] DataPoints { get; set; }
}
