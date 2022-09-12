using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaProductMediaList
{
	public List<InstaMedia> Medias { get; set; } = new List<InstaMedia>();


	public bool MoreAvailable { get; set; }

	public int ResultsCount { get; set; }

	public int TotalCount { get; set; }

	public bool AutoLoadMoreEnabled { get; set; }

	public string NextMaxId { get; set; }
}
