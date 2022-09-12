using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaBroadcastPostLive
{
	public string Pk { get; set; }

	public InstaUserShortFriendshipFull User { get; set; }

	public List<InstaBroadcastInfo> Broadcasts { get; set; } = new List<InstaBroadcastInfo>();


	public int PeakViewerCount { get; set; }
}
