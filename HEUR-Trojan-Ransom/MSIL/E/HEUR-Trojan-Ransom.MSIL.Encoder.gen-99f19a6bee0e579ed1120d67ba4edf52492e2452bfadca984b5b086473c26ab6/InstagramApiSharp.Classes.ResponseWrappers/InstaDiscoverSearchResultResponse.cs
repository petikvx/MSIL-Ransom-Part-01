using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaDiscoverSearchResultResponse
{
	[JsonProperty("num_results")]
	public int? NumResults { get; set; }

	[JsonProperty("users")]
	public List<InstaUserResponse> Users { get; set; }

	[JsonProperty("has_more")]
	public bool? HasMore { get; set; }

	[JsonProperty("rank_token")]
	public string RankToken { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
