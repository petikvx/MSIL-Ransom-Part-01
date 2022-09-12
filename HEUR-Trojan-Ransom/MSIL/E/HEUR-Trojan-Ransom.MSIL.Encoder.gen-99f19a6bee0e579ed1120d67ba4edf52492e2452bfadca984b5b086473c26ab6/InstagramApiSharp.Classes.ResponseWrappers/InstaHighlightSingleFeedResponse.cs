using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHighlightSingleFeedResponse : InstaHighlightFeedResponse
{
	[JsonProperty("items")]
	public List<InstaStoryItemResponse> Items { get; set; } = new List<InstaStoryItemResponse>();

}
