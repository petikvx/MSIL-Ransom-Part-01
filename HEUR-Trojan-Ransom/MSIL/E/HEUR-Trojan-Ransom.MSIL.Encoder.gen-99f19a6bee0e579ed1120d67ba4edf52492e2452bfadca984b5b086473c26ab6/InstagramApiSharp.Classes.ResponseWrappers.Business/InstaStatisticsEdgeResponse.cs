using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsEdgeResponse
{
	[JsonProperty("node")]
	public InstaMediaShortResponse Node { get; set; }
}
