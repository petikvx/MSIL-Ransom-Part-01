using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaMediaShortResponse
{
	[JsonProperty("image")]
	public InstaStatisticsImageResponse Image { get; set; }

	[JsonProperty("instagram_media_id")]
	public string MediaIdentifier { get; set; }

	[JsonProperty("instagram_media_type")]
	public string InstagramMediaType { get; set; }

	[JsonProperty("inline_insights_node")]
	public InstaStatisticsInlineInsightsNodeResponse InlineInsightsNode { get; set; }

	[JsonProperty("id")]
	public string Id { get; set; }
}
