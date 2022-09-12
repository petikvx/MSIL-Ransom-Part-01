using System;
using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaFullUserInfoUserStoryReel
{
	public InstaUserShort User { get; set; }

	public List<InstaStoryItem> Items { get; set; } = new List<InstaStoryItem>();


	public long Id { get; set; }

	public int? LatestReelMedia { get; set; }

	public DateTime ExpiringAt { get; set; }

	public long Seen { get; set; }

	public bool CanReply { get; set; }

	public bool CanReshare { get; set; }

	public string ReelType { get; set; }

	public int PrefetchCount { get; set; }

	public bool HasBestiesMedia { get; set; }
}
