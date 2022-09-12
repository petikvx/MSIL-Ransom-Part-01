using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsFollowersUnitResponse
{
	[JsonProperty("followers_unit_state")]
	public string FollowersUnitState { get; set; }

	[JsonProperty("followers_delta_from_last_week")]
	public int? FollowersDeltaFromLastWeek { get; set; } = 0;


	[JsonProperty("gender_graph")]
	public InstaStatisticsDataPointsResponse GenderGraph { get; set; }

	[JsonProperty("all_followers_age_graph")]
	public InstaStatisticsDataPointsResponse AllFollowersAgeGraph { get; set; }

	[JsonProperty("men_followers_age_graph")]
	public InstaStatisticsDataPointsResponse MenFollowersAgeGraph { get; set; }

	[JsonProperty("women_followers_age_graph")]
	public InstaStatisticsDataPointsResponse WomenFollowersAgeGraph { get; set; }

	[JsonProperty("followers_top_cities_graph")]
	public InstaStatisticsDataPointsResponse FollowersTopCitiesGraph { get; set; }

	[JsonProperty("followers_top_countries_graph")]
	public InstaStatisticsDataPointsResponse FollowersTopCountriesGraph { get; set; }

	[JsonProperty("week_daily_followers_graph")]
	public InstaStatisticsDataPointsResponse WeekDailyFollowersGraph { get; set; }

	[JsonProperty("days_hourly_followers_graphs")]
	public InstaStatisticsDaysHourlyFollowersGraphsResponse[] DaysHourlyFollowersGraphs { get; set; }

	[JsonProperty("today_hourly_graph")]
	public InstaStatisticsDataPointsResponse TodayHourlyGraph { get; set; }
}
