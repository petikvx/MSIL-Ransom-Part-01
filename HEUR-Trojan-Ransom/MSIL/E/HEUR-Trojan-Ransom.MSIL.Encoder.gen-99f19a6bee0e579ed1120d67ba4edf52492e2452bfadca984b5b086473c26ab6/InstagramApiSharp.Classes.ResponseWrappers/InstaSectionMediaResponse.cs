using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaSectionMediaResponse
{
	[JsonProperty("layout_type")]
	public string LayoutType { get; set; }

	[JsonProperty("layout_content")]
	public InstaSectionMediaLayoutContentResponse LayoutContent { get; set; }

	[JsonProperty("feed_type")]
	public string FeedType { get; set; }

	[JsonProperty("explore_item_info")]
	public InstaSectionMediaExploreItemInfoResponse ExploreItemInfo { get; set; }
}
