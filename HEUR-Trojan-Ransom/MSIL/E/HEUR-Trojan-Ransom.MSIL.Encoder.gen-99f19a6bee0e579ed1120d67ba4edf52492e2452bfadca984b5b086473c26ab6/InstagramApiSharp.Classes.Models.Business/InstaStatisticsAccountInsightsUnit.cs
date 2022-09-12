using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaStatisticsAccountInsightsUnit
{
	public int LastWeekWebsiteVisits { get; set; }

	public int WeekOverWeekWebsiteVisits { get; set; }

	public int LastWeekCall { get; set; }

	public int WeekOverWeekCall { get; set; }

	public int LastWeekText { get; set; }

	public int WeekOverWeekText { get; set; }

	public int LastWeekEmail { get; set; }

	public int WeekOverWeekEmail { get; set; }

	public int LastWeekGetDirection { get; set; }

	public int WeekOverWeekGetDirection { get; set; }

	public List<InstaStatisticsDataPointItem> AccountActionsLastWeekDailyGraph { get; set; } = new List<InstaStatisticsDataPointItem>();


	public int LastWeekProfileVisits { get; set; }

	public int WeekOverWeekProfileVisits { get; set; }

	public List<InstaStatisticsDataPointItem> AccountDiscoveryLastWeekDailyGraph { get; set; } = new List<InstaStatisticsDataPointItem>();


	public int LastWeekImpressions { get; set; }

	public int WeekOverWeekImpressions { get; set; }

	public int LastWeekReach { get; set; }

	public int WeekOverWeekReach { get; set; }

	public InstaStatisticsInsightsChannel InstagramAccountInsightsChannel { get; set; }
}
