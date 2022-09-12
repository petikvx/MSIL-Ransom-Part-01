using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountVerifySms
{
	[JsonProperty("verified")]
	public bool Verified { get; set; }

	[JsonProperty("errors")]
	public InstaAccountVerifySmsErrors Errors { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("error_type")]
	internal string ErrorType { get; set; }
}
