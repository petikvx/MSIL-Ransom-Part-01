using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryCountdownListResponse
{
	[JsonProperty("countdowns")]
	public List<InstaStoryCountdownStickerItemResponse> Items { get; set; }

	[JsonProperty("more_available")]
	public bool? MoreAvailable { get; set; }

	[JsonProperty("max_id")]
	public string MaxId { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
