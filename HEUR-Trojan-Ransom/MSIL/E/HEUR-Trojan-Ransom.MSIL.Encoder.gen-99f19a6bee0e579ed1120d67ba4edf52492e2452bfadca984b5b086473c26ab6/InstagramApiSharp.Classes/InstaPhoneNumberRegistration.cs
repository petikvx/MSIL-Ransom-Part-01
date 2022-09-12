using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaPhoneNumberRegistration
{
	[JsonProperty("verified")]
	public bool Verified { get; set; }

	[JsonProperty("phone_number")]
	public string PhoneNumber { get; set; }

	[JsonProperty("pn_taken")]
	public bool PnTaken { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("error_type")]
	public string ErrorType { get; set; }
}
