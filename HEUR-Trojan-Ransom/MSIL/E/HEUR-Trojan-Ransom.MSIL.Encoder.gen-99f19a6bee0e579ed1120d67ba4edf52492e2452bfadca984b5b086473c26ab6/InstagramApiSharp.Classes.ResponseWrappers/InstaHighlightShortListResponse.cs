using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHighlightShortListResponse : InstaDefault
{
	public List<InstaHighlightShortResponse> Items { get; set; }

	[JsonProperty("num_results")]
	public int ResultsCount { get; set; }

	[JsonProperty("more_available")]
	public bool MoreAvailable { get; set; }

	[JsonProperty("max_id")]
	public string MaxId { get; set; }
}
