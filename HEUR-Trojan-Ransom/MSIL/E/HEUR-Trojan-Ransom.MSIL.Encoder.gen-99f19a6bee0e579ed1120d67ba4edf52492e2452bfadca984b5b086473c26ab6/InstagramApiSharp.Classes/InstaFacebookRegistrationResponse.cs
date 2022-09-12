using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

internal class InstaFacebookRegistrationResponse
{
	[JsonProperty("account_created")]
	public bool? AccountCreated { get; set; }

	[JsonProperty("dryrun_passed")]
	public bool? DryrunPassed { get; set; }

	[JsonProperty("tos_version")]
	public string TosVersion { get; set; }

	[JsonProperty("gdpr_required")]
	public bool? GdprRequired { get; set; }

	[JsonProperty("fb_user_id")]
	public string FbUserId { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("username_suggestions_with_metadata")]
	public InstaRegistrationSuggestionsList UsernameSuggestionsWithMetadata { get; set; }
}
