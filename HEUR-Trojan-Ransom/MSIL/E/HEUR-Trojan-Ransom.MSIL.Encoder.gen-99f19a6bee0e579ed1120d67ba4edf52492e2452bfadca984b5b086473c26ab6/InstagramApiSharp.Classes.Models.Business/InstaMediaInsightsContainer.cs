using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models.Business;

internal class InstaMediaInsightsContainer : InstaDefaultResponse
{
	[JsonProperty("media_organic_insights")]
	public InstaMediaInsights MediaOrganicInsights { get; set; }
}
