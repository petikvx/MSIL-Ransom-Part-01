namespace InstagramApiSharp.Classes.Models.Business;

public class InstaStatisticsInsightsChannel
{
	public string Id { get; set; }

	public string ChannelId { get; set; }

	public object[] Tips { get; set; }

	public int UnseenCount { get; set; }
}
