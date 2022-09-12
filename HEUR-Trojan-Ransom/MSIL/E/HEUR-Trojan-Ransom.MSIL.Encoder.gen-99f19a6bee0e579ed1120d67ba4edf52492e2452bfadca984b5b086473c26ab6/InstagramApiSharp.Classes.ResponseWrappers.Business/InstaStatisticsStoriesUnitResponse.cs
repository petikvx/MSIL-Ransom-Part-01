using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsStoriesUnitResponse
{
	[JsonProperty("last_week_stories_count")]
	public long? LastWeekStoriesCount { get; set; } = 0L;


	[JsonProperty("week_over_week_stories_delta")]
	public long? WeekOverWeekStoriesDelta { get; set; } = 0L;


	[JsonProperty("state")]
	public string State { get; set; }

	[JsonProperty("summary_stories")]
	public InstaStatisticsSummaryStoriesResponse SummaryStories { get; set; }
}
