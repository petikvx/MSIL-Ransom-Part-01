using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaAdsInfoResponse
{
	[JsonProperty("has_ads")]
	public bool? HasAds { get; set; }

	[JsonProperty("ads_url")]
	public string AdsUrl { get; set; }
}
