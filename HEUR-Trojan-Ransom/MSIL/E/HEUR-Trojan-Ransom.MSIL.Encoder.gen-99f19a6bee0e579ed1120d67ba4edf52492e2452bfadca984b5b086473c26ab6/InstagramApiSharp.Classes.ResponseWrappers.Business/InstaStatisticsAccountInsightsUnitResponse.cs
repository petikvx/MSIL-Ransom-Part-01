using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsAccountInsightsUnitResponse
{
	[JsonProperty("last_week_website_visits")]
	public int? LastWeekWebsiteVisits { get; set; } = 0;


	[JsonProperty("week_over_week_website_visits")]
	public int? WeekOverWeekWebsiteVisits { get; set; } = 0;


	[JsonProperty("last_week_call")]
	public int? LastWeekCall { get; set; } = 0;


	[JsonProperty("week_over_week_call")]
	public int? WeekOverWeekCall { get; set; } = 0;


	[JsonProperty("last_week_text")]
	public int? LastWeekText { get; set; } = 0;


	[JsonProperty("week_over_week_text")]
	public int? WeekOverWeekText { get; set; } = 0;


	[JsonProperty("last_week_email")]
	public int? LastWeekEmail { get; set; } = 0;


	[JsonProperty("week_over_week_email")]
	public int? WeekOverWeekEmail { get; set; } = 0;


	[JsonProperty("last_week_get_direction")]
	public int? LastWeekGetDirection { get; set; } = 0;


	[JsonProperty("week_over_week_get_direction")]
	public int? WeekOverWeekGetDirection { get; set; } = 0;


	[JsonProperty("account_actions_last_week_daily_graph")]
	public InstaStatisticsDataPointsDailyNodesResponse AccountActionsLastWeekDailyGraph { get; set; }

	[JsonProperty("last_week_profile_visits")]
	public int? LastWeekProfileVisits { get; set; } = 0;


	[JsonProperty("week_over_week_profile_visits")]
	public int? WeekOverWeekProfileVisits { get; set; } = 0;


	[JsonProperty("account_discovery_last_week_daily_graph")]
	public InstaStatisticsDataPointsDicoveryDailyNodesResponse AccountDiscoveryLastWeekDailyGraph { get; set; }

	[JsonProperty("last_week_impressions")]
	public int? LastWeekImpressions { get; set; } = 0;


	[JsonProperty("week_over_week_impressions")]
	public int? WeekOverWeekImpressions { get; set; } = 0;


	[JsonProperty("last_week_reach")]
	public int? LastWeekReach { get; set; } = 0;


	[JsonProperty("week_over_week_reach")]
	public int? WeekOverWeekReach { get; set; } = 0;


	[JsonProperty("aymt_instagram_account_insights_channel")]
	public InstaStatisticsInsightsChannelResponse InstagramAccountInsightsChannel { get; set; }
}
