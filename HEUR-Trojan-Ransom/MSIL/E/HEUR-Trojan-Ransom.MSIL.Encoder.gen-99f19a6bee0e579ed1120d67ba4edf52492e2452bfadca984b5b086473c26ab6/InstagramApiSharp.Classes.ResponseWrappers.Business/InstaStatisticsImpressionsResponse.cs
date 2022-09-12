using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsImpressionsResponse
{
	[JsonProperty("organic")]
	public InstaStatisticsOrganicResponse Organic { get; set; }
}
