using InstagramApiSharp.Classes.Models.Business;
using InstagramApiSharp.Classes.ResponseWrappers.Business;

namespace InstagramApiSharp.Converters.Business;

internal class InstaStatisticsConverter : IObjectConverter<InstaStatistics, InstaStatisticsRootResponse>
{
	public InstaStatisticsRootResponse SourceObject { get; set; }

	public InstaStatistics Convert()
	{
		if (SourceObject?.Data?.User == null)
		{
			return null;
		}
		InstaStatisticsUserDataResponse user = SourceObject.Data.User;
		InstaStatistics instaStatistics = new InstaStatistics
		{
			BusinessProfileId = user.BusinessProfile.Id,
			FollowersCount = user.FollowersCount.GetValueOrDefault(),
			Id = user.Id,
			UserId = user.InstagramUserId,
			Username = user.Username
		};
		if (user.BusinessProfile != null && user.BusinessProfile.Id != null)
		{
			instaStatistics.BusinessProfileId = user.BusinessProfile.Id;
		}
		if (user.ProfilePicture != null && user.ProfilePicture.Uri != null)
		{
			instaStatistics.ProfilePicture = user.ProfilePicture.Uri;
		}
		instaStatistics.BusinessManager = new InstaStatisticsBusinessManager();
		InstaStatisticsBusinessManagerResponse businessManager = user.BusinessManager;
		if (businessManager.PromotionsUnit != null && businessManager.PromotionsUnit.SummaryPromotions != null)
		{
			try
			{
				instaStatistics.BusinessManager.PromotionsUnit = new InstaStatisticsSummaryPromotions
				{
					Edges = businessManager.PromotionsUnit.SummaryPromotions.Edges
				};
			}
			catch
			{
			}
		}
		if (businessManager.AccountSummaryUnit != null && businessManager.AccountSummaryUnit != null)
		{
			try
			{
				instaStatistics.BusinessManager.AccountSummaryUnit = new InstaStatisticsAccountSummaryUnit
				{
					FollowersCount = businessManager.AccountSummaryUnit.FollowersCount.GetValueOrDefault(),
					FollowersDeltaFromLastWeek = businessManager.AccountSummaryUnit.FollowersDeltaFromLastWeek.GetValueOrDefault(),
					PostsCount = businessManager.AccountSummaryUnit.PostsCount.GetValueOrDefault(),
					PostsDeltaFromLastWeek = businessManager.AccountSummaryUnit.PostsDeltaFromLastWeek.GetValueOrDefault()
				};
			}
			catch
			{
			}
		}
		if (businessManager.StoriesUnit != null)
		{
			try
			{
				InstaStatisticsStoriesUnit instaStatisticsStoriesUnit = new InstaStatisticsStoriesUnit
				{
					LastWeekStoriesCount = businessManager.StoriesUnit.LastWeekStoriesCount.GetValueOrDefault(),
					State = businessManager.StoriesUnit.State,
					WeekOverWeekStoriesDelta = businessManager.StoriesUnit.WeekOverWeekStoriesDelta.GetValueOrDefault()
				};
				if (businessManager.StoriesUnit.SummaryStories != null)
				{
					instaStatisticsStoriesUnit.SummaryStories = new InstaStatisticsSummaryStories
					{
						Count = businessManager.StoriesUnit.SummaryStories.Count.GetValueOrDefault(),
						Edges = businessManager.StoriesUnit.SummaryStories.Edges
					};
				}
				instaStatistics.BusinessManager.StoriesUnit = instaStatisticsStoriesUnit;
			}
			catch
			{
			}
		}
		if (businessManager.TopPostsUnit != null)
		{
			try
			{
				instaStatistics.BusinessManager.TopPostsUnit = new InstaStatisticsTopPostsUnit
				{
					LastWeekPostsCount = businessManager.TopPostsUnit.LastWeekPostsCount.GetValueOrDefault(),
					WeekOverWeekPostsDelta = businessManager.TopPostsUnit.WeekOverWeekPostsDelta.GetValueOrDefault()
				};
				if (businessManager.TopPostsUnit.SummaryPosts != null)
				{
					InstaStatisticsEdgeResponse[] edges = businessManager.TopPostsUnit.SummaryPosts.Edges;
					foreach (InstaStatisticsEdgeResponse instaStatisticsEdgeResponse in edges)
					{
						try
						{
							InstaMediaShort item = ConvertersFabric.Instance.GetMediaShortConverter(instaStatisticsEdgeResponse.Node).Convert();
							instaStatistics.BusinessManager.TopPostsUnit.SummaryPosts.Add(item);
						}
						catch
						{
						}
					}
				}
				if (businessManager.TopPostsUnit.TopPosts != null)
				{
					InstaStatisticsEdgeResponse[] edges = businessManager.TopPostsUnit.TopPosts.Edges;
					foreach (InstaStatisticsEdgeResponse instaStatisticsEdgeResponse2 in edges)
					{
						try
						{
							InstaMediaShort item2 = ConvertersFabric.Instance.GetMediaShortConverter(instaStatisticsEdgeResponse2.Node).Convert();
							instaStatistics.BusinessManager.TopPostsUnit.TopPosts.Add(item2);
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}
		if (businessManager.FollowersUnit != null)
		{
			try
			{
				instaStatistics.BusinessManager.FollowersUnit = new InstaStatisticsFollowersUnit
				{
					FollowersUnitState = businessManager.FollowersUnit.FollowersUnitState,
					FollowersDeltaFromLastWeek = businessManager.FollowersUnit.FollowersDeltaFromLastWeek.GetValueOrDefault()
				};
				InstaStatisticsDataPointItemResponse[] dataPoints = businessManager.FollowersUnit.AllFollowersAgeGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item3 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response).Convert();
						instaStatistics.BusinessManager.FollowersUnit.AllFollowersAgeGraph.Add(item3);
					}
					catch
					{
					}
				}
				InstaStatisticsDaysHourlyFollowersGraphsResponse[] daysHourlyFollowersGraphs = businessManager.FollowersUnit.DaysHourlyFollowersGraphs;
				for (int i = 0; i < daysHourlyFollowersGraphs.Length; i++)
				{
					dataPoints = daysHourlyFollowersGraphs[i].DataPoints;
					foreach (InstaStatisticsDataPointItemResponse response2 in dataPoints)
					{
						try
						{
							InstaStatisticsDataPointItem item4 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response2).Convert();
							instaStatistics.BusinessManager.FollowersUnit.DaysHourlyFollowersGraphs.Add(item4);
						}
						catch
						{
						}
					}
				}
				dataPoints = businessManager.FollowersUnit.FollowersTopCitiesGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response3 in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item5 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response3).Convert();
						instaStatistics.BusinessManager.FollowersUnit.FollowersTopCitiesGraph.Add(item5);
					}
					catch
					{
					}
				}
				dataPoints = businessManager.FollowersUnit.FollowersTopCountriesGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response4 in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item6 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response4).Convert();
						instaStatistics.BusinessManager.FollowersUnit.FollowersTopCountriesGraph.Add(item6);
					}
					catch
					{
					}
				}
				dataPoints = businessManager.FollowersUnit.GenderGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response5 in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item7 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response5).Convert();
						instaStatistics.BusinessManager.FollowersUnit.GenderGraph.Add(item7);
					}
					catch
					{
					}
				}
				dataPoints = businessManager.FollowersUnit.MenFollowersAgeGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response6 in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item8 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response6).Convert();
						instaStatistics.BusinessManager.FollowersUnit.MenFollowersAgeGraph.Add(item8);
					}
					catch
					{
					}
				}
				dataPoints = businessManager.FollowersUnit.TodayHourlyGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response7 in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item9 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response7).Convert();
						instaStatistics.BusinessManager.FollowersUnit.TodayHourlyGraph.Add(item9);
					}
					catch
					{
					}
				}
				dataPoints = businessManager.FollowersUnit.WeekDailyFollowersGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response8 in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item10 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response8).Convert();
						instaStatistics.BusinessManager.FollowersUnit.WeekDailyFollowersGraph.Add(item10);
					}
					catch
					{
					}
				}
				dataPoints = businessManager.FollowersUnit.WomenFollowersAgeGraph.DataPoints;
				foreach (InstaStatisticsDataPointItemResponse response9 in dataPoints)
				{
					try
					{
						InstaStatisticsDataPointItem item11 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response9).Convert();
						instaStatistics.BusinessManager.FollowersUnit.WomenFollowersAgeGraph.Add(item11);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		if (businessManager.AccountInsightsUnit != null)
		{
			try
			{
				instaStatistics.BusinessManager.AccountInsightsUnit = new InstaStatisticsAccountInsightsUnit
				{
					LastWeekCall = businessManager.AccountInsightsUnit.LastWeekCall.GetValueOrDefault(),
					LastWeekGetDirection = businessManager.AccountInsightsUnit.LastWeekGetDirection.GetValueOrDefault(),
					LastWeekImpressions = businessManager.AccountInsightsUnit.LastWeekImpressions.GetValueOrDefault(),
					LastWeekProfileVisits = businessManager.AccountInsightsUnit.LastWeekProfileVisits.GetValueOrDefault(),
					LastWeekReach = businessManager.AccountInsightsUnit.LastWeekReach.GetValueOrDefault(),
					LastWeekText = businessManager.AccountInsightsUnit.LastWeekText.GetValueOrDefault(),
					LastWeekWebsiteVisits = businessManager.AccountInsightsUnit.LastWeekWebsiteVisits.GetValueOrDefault(),
					LastWeekEmail = businessManager.AccountInsightsUnit.LastWeekWebsiteVisits.GetValueOrDefault(),
					WeekOverWeekCall = businessManager.AccountInsightsUnit.WeekOverWeekEmail.GetValueOrDefault(),
					WeekOverWeekEmail = businessManager.AccountInsightsUnit.WeekOverWeekEmail.GetValueOrDefault(),
					WeekOverWeekGetDirection = businessManager.AccountInsightsUnit.WeekOverWeekGetDirection.GetValueOrDefault(),
					WeekOverWeekImpressions = businessManager.AccountInsightsUnit.WeekOverWeekImpressions.GetValueOrDefault(),
					WeekOverWeekProfileVisits = businessManager.AccountInsightsUnit.WeekOverWeekReach.GetValueOrDefault(),
					WeekOverWeekReach = businessManager.AccountInsightsUnit.WeekOverWeekReach.GetValueOrDefault(),
					WeekOverWeekText = businessManager.AccountInsightsUnit.WeekOverWeekText.GetValueOrDefault(),
					WeekOverWeekWebsiteVisits = businessManager.AccountInsightsUnit.WeekOverWeekWebsiteVisits.GetValueOrDefault()
				};
				if (businessManager.AccountInsightsUnit.InstagramAccountInsightsChannel != null)
				{
					try
					{
						instaStatistics.BusinessManager.AccountInsightsUnit.InstagramAccountInsightsChannel = new InstaStatisticsInsightsChannel
						{
							ChannelId = businessManager.AccountInsightsUnit.InstagramAccountInsightsChannel.ChannelId,
							Id = businessManager.AccountInsightsUnit.InstagramAccountInsightsChannel.Id,
							Tips = businessManager.AccountInsightsUnit.InstagramAccountInsightsChannel.Tips,
							UnseenCount = businessManager.AccountInsightsUnit.InstagramAccountInsightsChannel.UnseenCount.GetValueOrDefault()
						};
					}
					catch
					{
					}
				}
				if (businessManager.AccountInsightsUnit.AccountActionsLastWeekDailyGraph != null && businessManager.AccountInsightsUnit.AccountActionsLastWeekDailyGraph.TotalCountGraph != null && businessManager.AccountInsightsUnit.AccountActionsLastWeekDailyGraph.TotalCountGraph.DataPoints != null)
				{
					InstaStatisticsDataPointItemResponse[] dataPoints = businessManager.AccountInsightsUnit.AccountActionsLastWeekDailyGraph.TotalCountGraph.DataPoints;
					foreach (InstaStatisticsDataPointItemResponse response10 in dataPoints)
					{
						try
						{
							InstaStatisticsDataPointItem item12 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response10).Convert();
							instaStatistics.BusinessManager.AccountInsightsUnit.AccountActionsLastWeekDailyGraph.Add(item12);
						}
						catch
						{
						}
					}
				}
				if (businessManager.AccountInsightsUnit.AccountDiscoveryLastWeekDailyGraph == null)
				{
					return instaStatistics;
				}
				if (businessManager.AccountInsightsUnit.AccountDiscoveryLastWeekDailyGraph.Nodes == null)
				{
					return instaStatistics;
				}
				InstaStatisticsDataPointsNodeResponse[] nodes = businessManager.AccountInsightsUnit.AccountDiscoveryLastWeekDailyGraph.Nodes;
				for (int i = 0; i < nodes.Length; i++)
				{
					InstaStatisticsDataPointItemResponse[] dataPoints = nodes[i].DataPoints;
					foreach (InstaStatisticsDataPointItemResponse response11 in dataPoints)
					{
						try
						{
							InstaStatisticsDataPointItem item13 = ConvertersFabric.Instance.GetStatisticsDataPointConverter(response11).Convert();
							instaStatistics.BusinessManager.AccountInsightsUnit.AccountDiscoveryLastWeekDailyGraph.Add(item13);
						}
						catch
						{
						}
					}
				}
				return instaStatistics;
			}
			catch
			{
				return instaStatistics;
			}
		}
		return instaStatistics;
	}
}
