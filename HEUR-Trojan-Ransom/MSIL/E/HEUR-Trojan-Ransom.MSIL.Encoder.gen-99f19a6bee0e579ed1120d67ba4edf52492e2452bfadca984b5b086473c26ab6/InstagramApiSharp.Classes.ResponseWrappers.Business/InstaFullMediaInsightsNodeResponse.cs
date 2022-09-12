using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaFullMediaInsightsNodeResponse
{
	[JsonProperty("nodes")]
	public InstaInsightsDataNodeResponse[] Nodes { get; set; }
}
