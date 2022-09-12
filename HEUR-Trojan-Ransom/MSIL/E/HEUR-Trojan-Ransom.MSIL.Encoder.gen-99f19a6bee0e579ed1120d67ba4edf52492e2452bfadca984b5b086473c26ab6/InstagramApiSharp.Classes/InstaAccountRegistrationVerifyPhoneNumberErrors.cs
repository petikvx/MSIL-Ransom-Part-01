using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

internal class InstaAccountRegistrationVerifyPhoneNumberErrors
{
	[JsonProperty("nonce")]
	public string[] Nonce { get; set; }
}
