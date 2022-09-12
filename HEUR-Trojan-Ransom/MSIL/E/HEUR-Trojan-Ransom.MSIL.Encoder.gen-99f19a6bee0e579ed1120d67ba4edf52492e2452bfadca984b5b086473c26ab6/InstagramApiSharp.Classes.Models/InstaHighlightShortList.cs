using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaHighlightShortList
{
	public List<InstaHighlightShort> Items { get; set; } = new List<InstaHighlightShort>();


	public int ResultsCount { get; set; }

	public bool MoreAvailable { get; set; }

	public string MaxId { get; set; }
}
