using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaStatisticsInsightsChannelResponse
{
	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("channel_id")]
	public string ChannelId { get; set; }

	[JsonProperty("tips")]
	public object[] Tips { get; set; }

	[JsonProperty("unseen_count")]
	public int? UnseenCount { get; set; } = 0;

}
