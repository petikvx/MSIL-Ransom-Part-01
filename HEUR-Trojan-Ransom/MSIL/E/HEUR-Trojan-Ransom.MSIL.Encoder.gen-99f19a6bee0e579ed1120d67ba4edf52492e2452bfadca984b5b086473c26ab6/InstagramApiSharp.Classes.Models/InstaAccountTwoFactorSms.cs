using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountTwoFactorSms
{
	[JsonProperty("phone_verification_settings")]
	public InstaAccountPhoneVerificationSettings PhoneVerificationSettings { get; set; }

	[JsonProperty("obfuscated_phone_number")]
	public string ObfuscatedPhoneNumber { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }
}
