using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsSummaryStoriesResponse : InstaStatisticsSummaryPromotionsResponse
{
	[JsonProperty("count")]
	public long? Count { get; set; } = 0L;

}
