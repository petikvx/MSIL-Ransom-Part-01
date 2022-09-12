using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsOrganicResponse
{
	[JsonProperty("value")]
	public long? Value { get; set; } = 0L;

}
