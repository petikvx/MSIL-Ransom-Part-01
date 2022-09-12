using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaBusinessPartner
{
	[JsonProperty("app_id")]
	public string AppId { get; set; }

	[JsonProperty("label")]
	public string Label { get; set; }

	[JsonProperty("partner_name")]
	public string PartnerName { get; set; }
}
