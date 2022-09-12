using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaActivityFeed : IInstaBaseList
{
	public bool IsOwnActivity { get; set; }

	public List<InstaRecentActivityFeed> Items { get; set; } = new List<InstaRecentActivityFeed>();


	public string NextMaxId { get; set; }
}
