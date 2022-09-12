using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaSuggestionResponse
{
	[JsonProperty("suggestions")]
	public InstaSuggestionItemListResponse Suggestions { get; set; } = new InstaSuggestionItemListResponse();

}
