using System;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaFullMediaInsights
{
	public string Id { get; set; }

	public InstaFullMediaInsightsMetrics InlineInsightsNode { get; set; }

	public DateTime CreationTime { get; set; }

	public string DisplayUrl { get; set; }

	public InstaMediaType MediaType { get; set; }

	public int CommentCount { get; set; }

	public int LikeCount { get; set; }

	public int SaveCount { get; set; }
}
