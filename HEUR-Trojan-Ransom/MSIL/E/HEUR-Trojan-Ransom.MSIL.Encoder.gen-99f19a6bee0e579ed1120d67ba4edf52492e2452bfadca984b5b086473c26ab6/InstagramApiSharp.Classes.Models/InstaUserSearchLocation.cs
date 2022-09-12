using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaUserSearchLocation
{
	[JsonProperty("list")]
	public List<InstaUserSearchLocationList> Items { get; set; }

	[JsonProperty("has_more")]
	public bool? HasMore { get; set; }

	[JsonProperty("rank_token")]
	public string RankToken { get; set; }

	[JsonProperty("clear_client_cache")]
	public bool? ClearClientCache { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }
}
