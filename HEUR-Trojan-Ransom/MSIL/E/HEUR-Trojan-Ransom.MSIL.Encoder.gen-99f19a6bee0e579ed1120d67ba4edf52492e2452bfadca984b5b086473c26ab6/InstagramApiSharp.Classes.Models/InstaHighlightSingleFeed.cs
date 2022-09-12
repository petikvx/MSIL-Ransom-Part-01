using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaHighlightSingleFeed : InstaHighlightFeed
{
	public List<InstaStoryItem> Items { get; set; } = new List<InstaStoryItem>();

}
