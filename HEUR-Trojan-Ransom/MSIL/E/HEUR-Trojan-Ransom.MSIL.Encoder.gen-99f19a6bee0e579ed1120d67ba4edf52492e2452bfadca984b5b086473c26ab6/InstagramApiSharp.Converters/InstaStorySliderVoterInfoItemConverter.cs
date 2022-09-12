using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaStorySliderVoterInfoItemConverter : IObjectConverter<InstaStorySliderVoterInfoItem, InstaStorySliderVoterInfoItemResponse>
{
	public InstaStorySliderVoterInfoItemResponse SourceObject { get; set; }

	public InstaStorySliderVoterInfoItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStorySliderVoterInfoItem instaStorySliderVoterInfoItem = new InstaStorySliderVoterInfoItem
		{
			LatestSliderVoteTime = (SourceObject.LatestSliderVoteTime ?? DateTime.Now.ToUnixTime()).FromUnixTimeSeconds(),
			MaxId = SourceObject.MaxId,
			MoreAvailable = SourceObject.MoreAvailable,
			SliderId = SourceObject.SliderId
		};
		List<InstaStoryVoterItemResponse> voters = SourceObject.Voters;
		if (voters != null && voters.Count > 0)
		{
			foreach (InstaStoryVoterItemResponse voter in SourceObject.Voters)
			{
				instaStorySliderVoterInfoItem.Voters.Add(ConvertersFabric.Instance.GetStoryPollVoterItemConverter(voter).Convert());
			}
			return instaStorySliderVoterInfoItem;
		}
		return instaStorySliderVoterInfoItem;
	}
}
