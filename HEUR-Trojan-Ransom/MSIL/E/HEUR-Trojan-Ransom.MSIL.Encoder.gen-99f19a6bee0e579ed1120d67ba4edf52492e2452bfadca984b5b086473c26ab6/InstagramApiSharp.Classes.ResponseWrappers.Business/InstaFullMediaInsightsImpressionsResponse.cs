using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsImpressionsResponse
{
	[JsonProperty("value")]
	public int? Value { get; set; }

	[JsonProperty("surfaces")]
	public InstaFullMediaInsightsNodeResponse Surfaces { get; set; }
}
