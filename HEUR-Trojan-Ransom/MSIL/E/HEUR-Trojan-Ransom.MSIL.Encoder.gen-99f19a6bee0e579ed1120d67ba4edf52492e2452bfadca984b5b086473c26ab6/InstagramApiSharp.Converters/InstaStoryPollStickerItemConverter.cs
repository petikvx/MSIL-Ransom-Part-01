using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryPollStickerItemConverter : IObjectConverter<InstaStoryPollStickerItem, InstaStoryPollStickerItemResponse>
{
	public InstaStoryPollStickerItemResponse SourceObject { get; set; }

	public InstaStoryPollStickerItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryPollStickerItem instaStoryPollStickerItem = new InstaStoryPollStickerItem
		{
			Finished = SourceObject.Finished,
			Id = SourceObject.Id,
			IsSharedResult = SourceObject.IsSharedResult,
			PollId = SourceObject.PollId,
			Question = SourceObject.Question,
			ViewerCanVote = SourceObject.ViewerCanVote,
			ViewerVote = SourceObject.ViewerVote.GetValueOrDefault()
		};
		List<InstaStoryTalliesItemResponse> tallies = SourceObject.Tallies;
		if (tallies != null && tallies.Count > 0)
		{
			foreach (InstaStoryTalliesItemResponse tally in SourceObject.Tallies)
			{
				try
				{
					instaStoryPollStickerItem.Tallies.Add(ConvertersFabric.Instance.GetStoryTalliesItemConverter(tally).Convert());
				}
				catch
				{
				}
			}
			return instaStoryPollStickerItem;
		}
		return instaStoryPollStickerItem;
	}
}
