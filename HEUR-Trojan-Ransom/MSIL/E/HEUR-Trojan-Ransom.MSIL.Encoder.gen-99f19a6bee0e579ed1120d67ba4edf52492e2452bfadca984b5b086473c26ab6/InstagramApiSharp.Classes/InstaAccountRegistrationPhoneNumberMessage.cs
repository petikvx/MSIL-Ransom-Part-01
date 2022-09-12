using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

internal class InstaAccountRegistrationPhoneNumberMessage
{
	[JsonProperty("errors")]
	public string[] Errors { get; set; }
}
