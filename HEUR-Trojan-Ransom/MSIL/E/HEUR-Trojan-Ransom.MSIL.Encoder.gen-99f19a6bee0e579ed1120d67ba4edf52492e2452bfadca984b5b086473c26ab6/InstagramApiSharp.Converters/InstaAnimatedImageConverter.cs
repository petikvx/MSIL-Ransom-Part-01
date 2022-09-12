using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaAnimatedImageConverter : IObjectConverter<InstaAnimatedImage, InstaAnimatedImageResponse>
{
	public InstaAnimatedImageResponse SourceObject { get; set; }

	public InstaAnimatedImage Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaAnimatedImage instaAnimatedImage = new InstaAnimatedImage
		{
			Id = SourceObject.Id,
			IsRandom = SourceObject.IsRandom.GetValueOrDefault(),
			IsSticker = SourceObject.IsSticker.GetValueOrDefault()
		};
		if (SourceObject.Images != null && SourceObject.Images?.Media != null)
		{
			instaAnimatedImage.Media = ConvertersFabric.Instance.GetAnimatedImageMediaConverter(SourceObject.Images.Media).Convert();
		}
		if (SourceObject.User != null)
		{
			instaAnimatedImage.User = ConvertersFabric.Instance.GetAnimatedImageUserConverter(SourceObject.User).Convert();
		}
		return instaAnimatedImage;
	}
}
