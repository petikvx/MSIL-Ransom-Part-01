using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHighlightFeedsResponse
{
	[JsonProperty("show_empty_state")]
	public bool? ShowEmptyState { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("tray")]
	public List<InstaHighlightFeedResponse> Items { get; set; } = new List<InstaHighlightFeedResponse>();

}
