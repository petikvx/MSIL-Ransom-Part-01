using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaHighlightFeeds
{
	public bool ShowEmptyState { get; set; }

	internal string Status { get; set; }

	public List<InstaHighlightFeed> Items { get; set; } = new List<InstaHighlightFeed>();

}
