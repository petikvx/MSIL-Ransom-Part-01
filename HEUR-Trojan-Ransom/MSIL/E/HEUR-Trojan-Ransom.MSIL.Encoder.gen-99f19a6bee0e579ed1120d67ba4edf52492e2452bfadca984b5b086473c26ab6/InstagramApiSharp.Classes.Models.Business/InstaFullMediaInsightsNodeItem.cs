using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaFullMediaInsightsNodeItem
{
	public int Value { get; set; }

	public List<InstaInsightsDataNode> Items { get; set; } = new List<InstaInsightsDataNode>();

}
