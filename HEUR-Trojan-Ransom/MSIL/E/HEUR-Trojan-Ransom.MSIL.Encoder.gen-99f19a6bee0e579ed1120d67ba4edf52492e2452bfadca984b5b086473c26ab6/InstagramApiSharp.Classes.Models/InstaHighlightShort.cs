using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaHighlightShort
{
	public DateTime Time { get; set; }

	public int MediaCount { get; set; }

	public string Id { get; set; }

	public string ReelType { get; set; }

	public int LatestReelMedia { get; set; }
}
