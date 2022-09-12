using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models.Business;

internal class InstaBusinessPartnerContainer : InstaDefault
{
	[JsonProperty("partners")]
	public InstaBusinessPartner[] Partners { get; set; }
}
