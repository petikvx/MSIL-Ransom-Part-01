using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaDiscoverSearches
{
	public int Position { get; set; }

	public InstaUser User { get; set; }

	public DateTime ClientTime { get; set; }
}
