using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsActionsResponse : InstaFullMediaInsightsNodeResponse
{
	[JsonProperty("value")]
	public int? Value { get; set; }
}
