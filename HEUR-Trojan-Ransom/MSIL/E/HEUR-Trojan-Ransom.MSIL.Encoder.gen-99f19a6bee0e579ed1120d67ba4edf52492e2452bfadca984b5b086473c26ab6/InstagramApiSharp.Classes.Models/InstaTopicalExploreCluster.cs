using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Classes.Models;

public class InstaTopicalExploreCluster
{
	public string Id { get; set; }

	public string Title { get; set; }

	public string Context { get; set; }

	public string Description { get; set; }

	public InstaExploreClusterType Type { get; set; }

	public string Name { get; set; }

	public bool CanMute { get; set; }

	public bool IsMuted { get; set; }

	public string DebugInfo { get; set; }

	public InstaMedia CoverMedia { get; set; }

	public int RankedPosition { get; set; }
}
