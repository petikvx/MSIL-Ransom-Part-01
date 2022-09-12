using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStorySliderItemConverter : IObjectConverter<InstaStorySliderItem, InstaStorySliderItemResponse>
{
	public InstaStorySliderItemResponse SourceObject { get; set; }

	public InstaStorySliderItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStorySliderItem instaStorySliderItem = new InstaStorySliderItem
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
		if (SourceObject.SliderSticker != null)
		{
			instaStorySliderItem.SliderSticker = ConvertersFabric.Instance.GetStorySliderStickerItemConverter(SourceObject.SliderSticker).Convert();
		}
		return instaStorySliderItem;
	}
}
