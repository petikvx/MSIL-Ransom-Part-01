using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

internal class InstaAccountRegistrationPhoneNumberVerifySms
{
	[JsonProperty("nonce_valid")]
	public bool NonceValid { get; set; }

	[JsonProperty("verified")]
	public bool Verified { get; set; }

	[JsonProperty("errors")]
	public InstaAccountRegistrationVerifyPhoneNumberErrors Errors { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("error_type")]
	public string ErrorType { get; set; }
}
