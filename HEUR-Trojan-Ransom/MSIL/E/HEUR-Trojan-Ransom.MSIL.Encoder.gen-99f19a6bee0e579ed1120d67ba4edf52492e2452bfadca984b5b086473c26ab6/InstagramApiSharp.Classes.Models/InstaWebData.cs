using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaWebData
{
	public string MaxId { get; set; }

	public List<InstaWebDataItem> Items { get; set; } = new List<InstaWebDataItem>();

}
