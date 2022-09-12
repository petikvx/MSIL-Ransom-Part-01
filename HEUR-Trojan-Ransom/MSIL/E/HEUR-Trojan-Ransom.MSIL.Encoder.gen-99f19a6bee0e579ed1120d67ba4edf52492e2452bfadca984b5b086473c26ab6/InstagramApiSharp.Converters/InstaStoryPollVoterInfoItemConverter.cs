using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryPollVoterInfoItemConverter : IObjectConverter<InstaStoryPollVoterInfoItem, InstaStoryPollVoterInfoItemResponse>
{
	public InstaStoryPollVoterInfoItemResponse SourceObject { get; set; }

	public InstaStoryPollVoterInfoItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryPollVoterInfoItem instaStoryPollVoterInfoItem = new InstaStoryPollVoterInfoItem
		{
			LatestPollVoteTime = (SourceObject.LatestPollVoteTime ?? DateTime.Now.ToUnixTime()).FromUnixTimeSeconds(),
			MaxId = SourceObject.MaxId,
			MoreAvailable = SourceObject.MoreAvailable,
			PollId = SourceObject.PollId
		};
		List<InstaStoryVoterItemResponse> voters = SourceObject.Voters;
		if (voters != null && voters.Count > 0)
		{
			foreach (InstaStoryVoterItemResponse voter in SourceObject.Voters)
			{
				instaStoryPollVoterInfoItem.Voters.Add(ConvertersFabric.Instance.GetStoryPollVoterItemConverter(voter).Convert());
			}
			return instaStoryPollVoterInfoItem;
		}
		return instaStoryPollVoterInfoItem;
	}
}
