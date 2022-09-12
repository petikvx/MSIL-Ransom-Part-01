using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryPollItemConverter : IObjectConverter<InstaStoryPollItem, InstaStoryPollItemResponse>
{
	public InstaStoryPollItemResponse SourceObject { get; set; }

	public InstaStoryPollItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryPollItem instaStoryPollItem = new InstaStoryPollItem
		{
			Height = SourceObject.Height,
			IsHidden = SourceObject.IsHidden,
			IsPinned = SourceObject.IsPinned,
			Rotation = SourceObject.Rotation,
			Width = SourceObject.Width,
			X = SourceObject.X,
			Y = SourceObject.Y,
			Z = SourceObject.Z
		};
		if (SourceObject.PollSticker != null)
		{
			instaStoryPollItem.PollSticker = ConvertersFabric.Instance.GetStoryPollStickerItemConverter(SourceObject.PollSticker).Convert();
		}
		return instaStoryPollItem;
	}
}
