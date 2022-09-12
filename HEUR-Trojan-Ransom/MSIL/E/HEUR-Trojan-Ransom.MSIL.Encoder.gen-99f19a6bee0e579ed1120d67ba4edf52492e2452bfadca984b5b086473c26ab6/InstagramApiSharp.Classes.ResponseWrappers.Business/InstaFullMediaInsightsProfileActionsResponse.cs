using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsProfileActionsResponse
{
	[JsonProperty("actions")]
	public InstaFullMediaInsightsActionsResponse Actions { get; set; }
}
