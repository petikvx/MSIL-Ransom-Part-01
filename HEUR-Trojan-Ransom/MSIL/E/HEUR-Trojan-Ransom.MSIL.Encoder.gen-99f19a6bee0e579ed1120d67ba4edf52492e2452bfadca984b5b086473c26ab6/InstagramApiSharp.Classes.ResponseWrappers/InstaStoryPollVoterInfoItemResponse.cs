using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryPollVoterInfoItemResponse
{
	[JsonProperty("poll_id")]
	public long PollId { get; set; }

	[JsonProperty("voters")]
	public List<InstaStoryVoterItemResponse> Voters { get; set; }

	[JsonProperty("max_id")]
	public string MaxId { get; set; }

	[JsonProperty("more_available")]
	public bool MoreAvailable { get; set; }

	[JsonProperty("latest_poll_vote_time")]
	public long? LatestPollVoteTime { get; set; }
}
