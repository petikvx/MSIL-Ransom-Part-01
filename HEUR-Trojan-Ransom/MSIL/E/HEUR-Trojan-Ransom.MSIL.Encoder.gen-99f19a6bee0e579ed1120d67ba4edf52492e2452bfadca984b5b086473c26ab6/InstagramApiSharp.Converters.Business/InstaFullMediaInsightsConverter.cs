using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.Models.Business;
using InstagramApiSharp.Classes.ResponseWrappers.Business;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters.Business;

internal class InstaFullMediaInsightsConverter : IObjectConverter<InstaFullMediaInsights, InstaFullMediaInsightsResponse>
{
	public InstaFullMediaInsightsResponse SourceObject { get; set; }

	public InstaFullMediaInsights Convert()
	{
		InstaFullMediaInsights instaFullMediaInsights = new InstaFullMediaInsights
		{
			CommentCount = SourceObject.CommentCount.GetValueOrDefault(),
			DisplayUrl = SourceObject.DisplayUrl,
			Id = SourceObject.Id,
			LikeCount = SourceObject.LikeCount.GetValueOrDefault(),
			SaveCount = SourceObject.SaveCount.GetValueOrDefault()
		};
		if (SourceObject.CreationTime.HasValue)
		{
			instaFullMediaInsights.CreationTime = DateTimeHelper.UnixTimestampToDateTime(SourceObject.CreationTime.ToString());
		}
		if (SourceObject.InstagramMediaType != null)
		{
			try
			{
				instaFullMediaInsights.MediaType = (InstaMediaType)Enum.Parse(typeof(InstaMediaType), SourceObject.InstagramMediaType, ignoreCase: true);
			}
			catch
			{
			}
		}
		InstaFullMediaInsightsInlineNodeResponse inlineInsightsNode = SourceObject.InlineInsightsNode;
		if (SourceObject.InlineInsightsNode != null)
		{
			InstaFullMediaInsightsMetrics instaFullMediaInsightsMetrics = new InstaFullMediaInsightsMetrics
			{
				State = inlineInsightsNode.State
			};
			if (inlineInsightsNode.Metrics != null)
			{
				instaFullMediaInsightsMetrics.ImpressionCount = inlineInsightsNode.Metrics.ImpressionCount.GetValueOrDefault();
				instaFullMediaInsightsMetrics.OwnerAccountFollowsCount = inlineInsightsNode.Metrics.OwnerAccountFollowsCount.GetValueOrDefault();
				instaFullMediaInsightsMetrics.OwnerProfileViewsCount = inlineInsightsNode.Metrics.OwnerProfileViewsCount.GetValueOrDefault();
				instaFullMediaInsightsMetrics.ReachCount = inlineInsightsNode.Metrics.ReachCount.GetValueOrDefault();
				if (inlineInsightsNode.Metrics.Reach != null)
				{
					try
					{
						InstaFullMediaInsightsNodeItem instaFullMediaInsightsNodeItem = new InstaFullMediaInsightsNodeItem
						{
							Value = inlineInsightsNode.Metrics.Reach.Value.GetValueOrDefault()
						};
						InstaInsightsDataNodeResponse[] nodes = inlineInsightsNode.Metrics.Reach.FollowStatus.Nodes;
						foreach (InstaInsightsDataNodeResponse response in nodes)
						{
							InstaInsightsDataNode item = ConvertersFabric.Instance.GetInsightsDataNodeConverter(response).Convert();
							instaFullMediaInsightsNodeItem.Items.Add(item);
						}
						instaFullMediaInsightsMetrics.Reach = instaFullMediaInsightsNodeItem;
					}
					catch
					{
					}
				}
				if (inlineInsightsNode.Metrics.Impressions != null)
				{
					try
					{
						InstaFullMediaInsightsNodeItem instaFullMediaInsightsNodeItem2 = new InstaFullMediaInsightsNodeItem
						{
							Value = inlineInsightsNode.Metrics.Impressions.Value.GetValueOrDefault()
						};
						InstaInsightsDataNodeResponse[] nodes = inlineInsightsNode.Metrics.Impressions.Surfaces.Nodes;
						foreach (InstaInsightsDataNodeResponse response2 in nodes)
						{
							InstaInsightsDataNode item2 = ConvertersFabric.Instance.GetInsightsDataNodeConverter(response2).Convert();
							instaFullMediaInsightsNodeItem2.Items.Add(item2);
						}
						instaFullMediaInsightsMetrics.Impressions = instaFullMediaInsightsNodeItem2;
					}
					catch
					{
					}
				}
				if (inlineInsightsNode.Metrics.ProfileActions != null)
				{
					try
					{
						InstaFullMediaInsightsNodeItem instaFullMediaInsightsNodeItem3 = new InstaFullMediaInsightsNodeItem
						{
							Value = inlineInsightsNode.Metrics.ProfileActions.Actions.Value.GetValueOrDefault()
						};
						InstaInsightsDataNodeResponse[] nodes = inlineInsightsNode.Metrics.ProfileActions.Actions.Nodes;
						foreach (InstaInsightsDataNodeResponse response3 in nodes)
						{
							InstaInsightsDataNode item3 = ConvertersFabric.Instance.GetInsightsDataNodeConverter(response3).Convert();
							instaFullMediaInsightsNodeItem3.Items.Add(item3);
						}
						instaFullMediaInsightsMetrics.ProfileActions = instaFullMediaInsightsNodeItem3;
					}
					catch
					{
					}
				}
			}
			instaFullMediaInsights.InlineInsightsNode = instaFullMediaInsightsMetrics;
		}
		return instaFullMediaInsights;
	}
}
