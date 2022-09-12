using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaStatisticsTopPostsUnit
{
	public long LastWeekPostsCount { get; set; }

	public long WeekOverWeekPostsDelta { get; set; }

	public List<InstaMediaShort> SummaryPosts { get; set; } = new List<InstaMediaShort>();


	public List<InstaMediaShort> TopPosts { get; set; } = new List<InstaMediaShort>();

}
