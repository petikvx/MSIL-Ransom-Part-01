using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsAccountSummaryUnitResponse
{
	[JsonProperty("posts_count")]
	public long? PostsCount { get; set; } = 0L;


	[JsonProperty("followers_count")]
	public long? FollowersCount { get; set; } = 0L;


	[JsonProperty("followers_delta_from_last_week")]
	public long? FollowersDeltaFromLastWeek { get; set; } = 0L;


	[JsonProperty("posts_delta_from_last_week")]
	public long? PostsDeltaFromLastWeek { get; set; } = 0L;

}
