using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaAccountDetailsResponse
{
	[JsonProperty("date_joined")]
	public int? DateJoined { get; set; }

	[JsonProperty("former_username_info")]
	public InstaFormerUsernameInfoResponse FormerUsernameInfo { get; set; }

	[JsonProperty("primary_country_info")]
	public InstaPrimaryCountryInfoResponse PrimaryCountryInfo { get; set; }

	[JsonProperty("shared_follower_accounts_info")]
	public InstaSharedFollowerAccountsInfoResponse SharedFollowerAccountsInfo { get; set; }

	[JsonProperty("ads_info")]
	public InstaAdsInfoResponse AdsInfo { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
