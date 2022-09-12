using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaSuggestions
{
	public bool MoreAvailable { get; set; }

	public string NextMaxId { get; set; }

	public List<InstaSuggestionItem> SuggestedUsers { get; set; } = new List<InstaSuggestionItem>();


	public List<InstaSuggestionItem> NewSuggestedUsers { get; set; } = new List<InstaSuggestionItem>();

}
