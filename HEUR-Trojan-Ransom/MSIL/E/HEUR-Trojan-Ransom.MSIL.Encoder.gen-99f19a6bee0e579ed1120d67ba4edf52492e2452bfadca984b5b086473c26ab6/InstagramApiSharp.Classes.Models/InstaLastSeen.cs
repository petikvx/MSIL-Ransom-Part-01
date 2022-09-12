using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaLastSeen : InstaLastSeenItemResponse
{
	public long PK { get; set; }

	public DateTime SeenTime { get; set; }
}
