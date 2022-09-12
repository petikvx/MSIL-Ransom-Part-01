using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaDiscoverSearchResult
{
	public int NumResults { get; set; }

	public List<InstaUser> Users { get; set; } = new List<InstaUser>();


	public bool HasMoreAvailable { get; set; }

	public string RankToken { get; set; }
}
