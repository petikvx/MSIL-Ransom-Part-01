using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaDiscoverSuggestedSearches
{
	public string RankToken { get; set; }

	public List<InstaDiscoverSearches> Suggested { get; set; } = new List<InstaDiscoverSearches>();

}
