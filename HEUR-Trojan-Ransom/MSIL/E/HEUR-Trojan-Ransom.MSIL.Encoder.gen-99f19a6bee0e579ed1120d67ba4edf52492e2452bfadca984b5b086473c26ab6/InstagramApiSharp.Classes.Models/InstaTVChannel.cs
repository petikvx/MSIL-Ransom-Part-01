using System.Collections.Generic;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Classes.Models;

public class InstaTVChannel
{
	public InstaTVChannelType Type { get; set; }

	public string Title { get; set; }

	public string Id { get; set; }

	public List<InstaMedia> Items { get; set; } = new List<InstaMedia>();


	public bool HasMoreAvailable { get; set; }

	public string MaxId { get; set; }

	public InstaTVUser UserDetail { get; set; }
}
