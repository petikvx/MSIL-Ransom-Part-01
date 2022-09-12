using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsReachResponse
{
	[JsonProperty("value")]
	public int? Value { get; set; }

	[JsonProperty("follow_status")]
	public InstaFullMediaInsightsNodeResponse FollowStatus { get; set; }
}
