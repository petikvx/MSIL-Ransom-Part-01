using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsRootResponse
{
	[JsonProperty("data")]
	public InstaStatisticsDataResponse Data { get; set; }
}
