using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaStoryCountdownList
{
	public List<InstaStoryCountdownStickerItem> Items { get; set; } = new List<InstaStoryCountdownStickerItem>();


	public bool MoreAvailable { get; set; }

	public string MaxId { get; set; }
}
