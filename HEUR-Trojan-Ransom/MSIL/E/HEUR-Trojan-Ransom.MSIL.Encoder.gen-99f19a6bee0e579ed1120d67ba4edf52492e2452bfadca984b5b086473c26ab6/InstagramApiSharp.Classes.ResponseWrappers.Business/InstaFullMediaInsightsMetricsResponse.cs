using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsMetricsResponse
{
	[JsonProperty("owner_profile_views_count")]
	public int? OwnerProfileViewsCount { get; set; }

	[JsonProperty("reach_count")]
	public int? ReachCount { get; set; }

	[JsonProperty("profile_actions")]
	public InstaFullMediaInsightsProfileActionsResponse ProfileActions { get; set; }

	[JsonProperty("impression_count")]
	public int? ImpressionCount { get; set; }

	[JsonProperty("impressions")]
	public InstaFullMediaInsightsImpressionsResponse Impressions { get; set; }

	[JsonProperty("owner_account_follows_count")]
	public int? OwnerAccountFollowsCount { get; set; }

	[JsonProperty("reach")]
	public InstaFullMediaInsightsReachResponse Reach { get; set; }
}
