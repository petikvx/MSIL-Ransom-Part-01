using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaReelStoryMediaViewers
{
	public string NextMaxId { get; set; }

	public int TotalScreenshotCount { get; set; }

	public int TotalViewerCount { get; set; }

	public InstaStoryItem UpdatedMedia { get; set; }

	public int UserCount { get; set; }

	public List<InstaUserShort> Users { get; set; } = new List<InstaUserShort>();

}
