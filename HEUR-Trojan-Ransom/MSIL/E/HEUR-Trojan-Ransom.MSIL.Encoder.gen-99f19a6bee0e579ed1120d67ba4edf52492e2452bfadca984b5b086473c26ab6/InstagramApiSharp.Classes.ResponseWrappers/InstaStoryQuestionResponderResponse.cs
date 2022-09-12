using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryQuestionResponderResponse
{
	[JsonProperty("response")]
	public string Response { get; set; }

	[JsonProperty("has_shared_response")]
	public bool? HasSharedResponse { get; set; }

	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("user")]
	public InstaUserShortResponse User { get; set; }

	[JsonProperty("ts")]
	public long? Ts { get; set; }
}
