using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaSectionMedia
{
	public List<InstaMedia> Medias { get; set; } = new List<InstaMedia>();


	public List<InstaRelatedHashtag> RelatedHashtags { get; set; } = new List<InstaRelatedHashtag>();


	public bool MoreAvailable { get; set; }

	public string NextMaxId { get; set; }

	public int NextPage { get; set; }

	public List<long> NextMediaIds { get; set; } = new List<long>();


	public bool AutoLoadMoreEnabled { get; set; }
}
