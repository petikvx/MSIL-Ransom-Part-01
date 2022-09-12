namespace InstagramApiSharp.Classes.Models.Business;

public class InstaFullMediaInsightsMetrics
{
	public string State { get; set; }

	public int OwnerProfileViewsCount { get; set; }

	public int ReachCount { get; set; }

	public InstaFullMediaInsightsNodeItem ProfileActions { get; set; }

	public int ImpressionCount { get; set; }

	public InstaFullMediaInsightsNodeItem Impressions { get; set; }

	public int OwnerAccountFollowsCount { get; set; }

	public InstaFullMediaInsightsNodeItem Reach { get; set; }
}
