using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryPollVotersListConverter : IObjectConverter<InstaStoryPollVotersList, InstaStoryPollVotersListResponse>
{
	public InstaStoryPollVotersListResponse SourceObject { get; set; }

	public InstaStoryPollVotersList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryPollVotersList instaStoryPollVotersList = new InstaStoryPollVotersList
		{
			LatestPollVoteTime = SourceObject.LatestPollVoteTime.GetValueOrDefault().FromUnixTimeSeconds(),
			MaxId = SourceObject.MaxId,
			MoreAvailable = SourceObject.MoreAvailable,
			PollId = SourceObject.PollId
		};
		List<InstaStoryVoterItemResponse> voters = SourceObject.Voters;
		if (voters != null && voters.Count > 0)
		{
			foreach (InstaStoryVoterItemResponse voter in SourceObject.Voters)
			{
				instaStoryPollVotersList.Voters.Add(ConvertersFabric.Instance.GetStoryPollVoterItemConverter(voter).Convert());
			}
			return instaStoryPollVotersList;
		}
		return instaStoryPollVotersList;
	}
}
