using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsTopPostsResponse
{
	[JsonProperty("edges")]
	public InstaStatisticsEdgeResponse[] Edges { get; set; }
}
