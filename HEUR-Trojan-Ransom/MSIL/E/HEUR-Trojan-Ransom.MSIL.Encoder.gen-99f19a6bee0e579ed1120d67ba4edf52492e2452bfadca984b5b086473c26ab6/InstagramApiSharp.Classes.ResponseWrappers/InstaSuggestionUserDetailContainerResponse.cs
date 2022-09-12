using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaSuggestionUserDetailContainerResponse : InstaDefault
{
	[JsonProperty("items")]
	public InstaSuggestionItemListResponse Items { get; set; } = new InstaSuggestionItemListResponse();

}
