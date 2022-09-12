using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaRavenMediaActionSummary
{
	public InstaRavenType Type { get; set; }

	public DateTime ExpireTime { get; set; }

	public int Count { get; set; }
}
