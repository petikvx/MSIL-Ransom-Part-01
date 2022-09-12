namespace InstagramApiSharp.Classes.Models.Business;

public class InstaStatisticsStoriesUnit
{
	public long LastWeekStoriesCount { get; set; }

	public long WeekOverWeekStoriesDelta { get; set; }

	public string State { get; set; }

	public InstaStatisticsSummaryStories SummaryStories { get; set; }
}
