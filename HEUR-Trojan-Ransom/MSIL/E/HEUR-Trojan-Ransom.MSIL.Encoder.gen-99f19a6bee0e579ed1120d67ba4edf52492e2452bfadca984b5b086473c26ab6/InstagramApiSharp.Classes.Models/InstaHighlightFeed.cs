namespace InstagramApiSharp.Classes.Models;

public class InstaHighlightFeed
{
	public string HighlightId { get; set; }

	public int LatestReelMedia { get; set; }

	public object Seen { get; set; }

	public bool CanReply { get; set; }

	public object CanReshare { get; set; }

	public string ReelType { get; set; }

	public InstaHighlightCoverMedia CoverMedia { get; set; }

	public InstaUserShort User { get; set; }

	public int RankedPosition { get; set; }

	public string Title { get; set; }

	public int SeenRankedPosition { get; set; }

	public int PrefetchCount { get; set; }

	public int MediaCount { get; set; }
}
