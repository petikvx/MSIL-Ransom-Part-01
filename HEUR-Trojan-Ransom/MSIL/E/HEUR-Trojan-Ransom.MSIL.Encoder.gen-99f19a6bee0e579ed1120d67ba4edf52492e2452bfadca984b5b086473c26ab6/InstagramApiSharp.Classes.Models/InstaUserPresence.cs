using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaUserPresence
{
	public bool IsActive { get; set; }

	public DateTime LastActivity { get; set; }

	public long Pk { get; set; }
}
