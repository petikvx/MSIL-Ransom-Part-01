using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

internal class InstaAccountCreationResponse : InstaAccountCreation
{
	[JsonProperty("error_type")]
	public string ErrorType { get; set; }

	[JsonProperty("errors")]
	public InstaAccountCreationErrors Errors { get; set; }
}
