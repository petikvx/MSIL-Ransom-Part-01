using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaDiscoverTopLive
{
	public InstaBroadcastList Broadcasts { get; set; } = new InstaBroadcastList();


	public List<InstaBroadcastPostLive> PostLiveBroadcasts { get; set; } = new List<InstaBroadcastPostLive>();


	public bool MoreAvailable { get; set; }

	public bool AutoLoadMoreEnabled { get; set; }

	public string NextMaxId { get; set; }
}
