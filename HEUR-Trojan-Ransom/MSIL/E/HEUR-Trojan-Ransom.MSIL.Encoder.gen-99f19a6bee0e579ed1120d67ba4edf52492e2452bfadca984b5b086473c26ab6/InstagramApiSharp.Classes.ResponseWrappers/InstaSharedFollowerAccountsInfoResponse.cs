using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaSharedFollowerAccountsInfoResponse
{
	[JsonProperty("has_shared_follower_accounts")]
	public bool? HasSharedFollowerAccounts { get; set; }
}
