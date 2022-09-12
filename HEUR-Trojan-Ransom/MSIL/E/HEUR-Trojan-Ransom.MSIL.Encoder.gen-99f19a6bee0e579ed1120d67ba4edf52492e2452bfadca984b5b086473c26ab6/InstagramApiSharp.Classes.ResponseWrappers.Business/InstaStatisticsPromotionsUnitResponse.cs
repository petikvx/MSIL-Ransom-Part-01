using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsPromotionsUnitResponse
{
	[JsonProperty("summary_promotions")]
	public InstaStatisticsSummaryPromotionsResponse SummaryPromotions { get; set; }
}
