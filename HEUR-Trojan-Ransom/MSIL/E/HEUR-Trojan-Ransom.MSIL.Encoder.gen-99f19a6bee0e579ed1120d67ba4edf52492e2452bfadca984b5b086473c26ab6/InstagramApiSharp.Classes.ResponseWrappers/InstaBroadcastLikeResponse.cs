using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastLikeResponse
{
	[JsonProperty("likes")]
	public int Likes { get; set; }

	[JsonProperty("burst_likes")]
	public int BurstLikes { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("like_ts")]
	public long? LikeTs { get; set; }
}
