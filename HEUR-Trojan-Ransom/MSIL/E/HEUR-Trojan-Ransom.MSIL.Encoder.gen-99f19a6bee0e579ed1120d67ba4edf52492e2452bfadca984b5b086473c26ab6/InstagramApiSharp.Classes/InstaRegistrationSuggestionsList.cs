using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaRegistrationSuggestionsList
{
	[JsonProperty("suggestions")]
	public InstaRegistrationSuggestion[] Suggestions { get; set; }
}
