using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaRegistrationSuggestionResponse
{
	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("suggestions_with_metadata")]
	public InstaRegistrationSuggestionsList SuggestionsWithMetadata { get; set; }
}
