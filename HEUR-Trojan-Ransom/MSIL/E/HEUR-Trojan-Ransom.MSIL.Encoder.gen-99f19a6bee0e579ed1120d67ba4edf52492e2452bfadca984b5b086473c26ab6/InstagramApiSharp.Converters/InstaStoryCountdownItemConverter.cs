using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryCountdownItemConverter : IObjectConverter<InstaStoryCountdownItem, InstaStoryCountdownItemResponse>
{
	public InstaStoryCountdownItemResponse SourceObject { get; set; }

	public InstaStoryCountdownItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryCountdownItem instaStoryCountdownItem = new InstaStoryCountdownItem
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
		if (SourceObject.CountdownSticker != null)
		{
			instaStoryCountdownItem.CountdownSticker = ConvertersFabric.Instance.GetStoryCountdownStickerItemConverter(SourceObject.CountdownSticker).Convert();
		}
		return instaStoryCountdownItem;
	}
}
