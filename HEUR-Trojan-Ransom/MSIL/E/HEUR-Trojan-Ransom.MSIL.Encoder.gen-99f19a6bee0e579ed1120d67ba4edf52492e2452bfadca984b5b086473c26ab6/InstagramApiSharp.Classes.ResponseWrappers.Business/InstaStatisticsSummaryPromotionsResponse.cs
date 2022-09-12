using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsSummaryPromotionsResponse
{
	[JsonProperty("edges")]
	public object[] Edges { get; set; }
}
