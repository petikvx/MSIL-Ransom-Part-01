using System;
using System.Globalization;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaRecentActivityConverter : IObjectConverter<InstaRecentActivityFeed, InstaRecentActivityFeedResponse>
{
	public InstaRecentActivityFeedResponse SourceObject { get; set; }

	public InstaRecentActivityFeed Convert()
	{
		InstaRecentActivityFeed instaRecentActivityFeed = new InstaRecentActivityFeed
		{
			Pk = SourceObject.Pk,
			Type = SourceObject.Type,
			ProfileId = SourceObject.Args.ProfileId,
			ProfileImage = SourceObject.Args.ProfileImage,
			Text = SourceObject.Args.Text,
			RichText = SourceObject.Args.RichText,
			TimeStamp = DateTimeHelper.UnixTimestampToDateTime((long)System.Convert.ToDouble(SourceObject.Args.TimeStamp, new NumberFormatInfo
			{
				NumberDecimalSeparator = "."
			}))
		};
		if (SourceObject.Args.Links != null)
		{
			foreach (InstaLinkResponse link in SourceObject.Args.Links)
			{
				instaRecentActivityFeed.Links.Add(new InstaLink
				{
					Start = link.Start,
					End = link.End,
					Id = link.Id,
					Type = link.Type
				});
			}
		}
		if (SourceObject.Args.InlineFollow != null)
		{
			instaRecentActivityFeed.InlineFollow = new InstaInlineFollow
			{
				IsFollowing = SourceObject.Args.InlineFollow.IsFollowing,
				IsOutgoingRequest = SourceObject.Args.InlineFollow.IsOutgoingRequest
			};
			if (SourceObject.Args.InlineFollow.UserInfo != null)
			{
				instaRecentActivityFeed.InlineFollow.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.Args.InlineFollow.UserInfo).Convert();
			}
		}
		if (SourceObject.Args.Media != null)
		{
			foreach (InstaActivityMediaResponse medium in SourceObject.Args.Media)
			{
				instaRecentActivityFeed.Medias.Add(new InstaActivityMedia
				{
					Id = medium.Id,
					Image = medium.Image
				});
			}
			return instaRecentActivityFeed;
		}
		return instaRecentActivityFeed;
	}
}
