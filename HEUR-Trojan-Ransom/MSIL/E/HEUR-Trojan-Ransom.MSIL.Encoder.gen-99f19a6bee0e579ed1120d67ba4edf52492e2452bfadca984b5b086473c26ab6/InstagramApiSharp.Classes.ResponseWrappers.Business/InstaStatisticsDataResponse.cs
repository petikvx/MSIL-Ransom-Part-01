using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsDataResponse
{
	[JsonProperty("user")]
	public InstaStatisticsUserDataResponse User { get; set; }
}
