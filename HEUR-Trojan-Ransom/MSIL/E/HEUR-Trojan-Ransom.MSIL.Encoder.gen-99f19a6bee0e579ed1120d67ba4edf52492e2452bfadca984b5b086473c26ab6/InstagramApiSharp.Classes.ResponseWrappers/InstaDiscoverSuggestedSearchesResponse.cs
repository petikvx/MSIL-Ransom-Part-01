using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaDiscoverSuggestedSearchesResponse
{
	[JsonProperty("rank_token")]
	public string RankToken { get; set; }

	[JsonProperty("suggested")]
	public List<InstaDiscoverSearchesResponse> Suggested { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
