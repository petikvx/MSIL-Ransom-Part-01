using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStorySliderStickerItemConverter : IObjectConverter<InstaStorySliderStickerItem, InstaStorySliderStickerItemResponse>
{
	public InstaStorySliderStickerItemResponse SourceObject { get; set; }

	public InstaStorySliderStickerItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaStorySliderStickerItem
		{
			Emoji = SourceObject.Emoji,
			Question = SourceObject.Question,
			SliderId = SourceObject.SliderId,
			SliderVoteAverage = ((!SourceObject.SliderVoteAverage.HasValue) ? 0.0 : SourceObject.SliderVoteAverage.Value),
			SliderVoteCount = ((!SourceObject.SliderVoteCount.HasValue) ? 0L : SourceObject.SliderVoteCount.Value),
			TextColor = SourceObject.TextColor,
			ViewerCanVote = SourceObject.ViewerCanVote
		};
	}
}
