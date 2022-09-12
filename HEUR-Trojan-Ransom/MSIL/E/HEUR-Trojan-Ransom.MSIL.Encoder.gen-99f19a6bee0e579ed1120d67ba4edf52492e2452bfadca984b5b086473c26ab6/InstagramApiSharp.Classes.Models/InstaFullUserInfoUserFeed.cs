using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaFullUserInfoUserFeed
{
	public int NumResults { get; set; }

	public bool MoreAvailable { get; set; }

	public string NextMaxId { get; set; }

	public string NextMinId { get; set; }

	public bool AutoLoadMoreEnabled { get; set; }

	public List<InstaMedia> Items { get; set; } = new List<InstaMedia>();

}
