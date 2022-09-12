using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaTV
{
	public List<InstaTVChannel> Channels { get; set; } = new List<InstaTVChannel>();


	public InstaTVSelfChannel MyChannel { get; set; }

	internal string Status { get; set; }
}
