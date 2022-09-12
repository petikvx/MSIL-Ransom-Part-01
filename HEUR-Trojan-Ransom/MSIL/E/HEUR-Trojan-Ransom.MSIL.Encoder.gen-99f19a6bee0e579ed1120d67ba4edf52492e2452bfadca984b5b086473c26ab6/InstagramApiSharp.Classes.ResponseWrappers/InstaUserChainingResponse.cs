using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaUserChainingResponse : InstaUserShortResponse
{
	[JsonProperty("chaining_info")]
	public InstaUserChainingInfoResponse ChainingInfo { get; set; }

	[JsonProperty("profile_chaining_secondary_label")]
	public string ProfileChainingSecondaryLabel { get; set; }
}
