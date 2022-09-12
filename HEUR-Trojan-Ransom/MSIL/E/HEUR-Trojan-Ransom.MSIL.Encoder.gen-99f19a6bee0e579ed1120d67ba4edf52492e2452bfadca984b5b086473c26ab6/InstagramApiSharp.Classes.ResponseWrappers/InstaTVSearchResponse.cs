using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTVSearchResponse
{
	[JsonProperty("results")]
	public List<InstaTVSearchResultResponse> Results { get; set; }

	[JsonProperty("num_results")]
	public int? NumResults { get; set; }

	[JsonProperty("rank_token")]
	public string RankToken { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }
}
