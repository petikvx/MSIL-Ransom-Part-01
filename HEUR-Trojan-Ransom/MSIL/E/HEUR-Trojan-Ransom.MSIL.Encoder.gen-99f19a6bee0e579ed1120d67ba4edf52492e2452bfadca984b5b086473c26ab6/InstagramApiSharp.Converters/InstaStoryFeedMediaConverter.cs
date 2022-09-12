using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryFeedMediaConverter : IObjectConverter<InstaStoryFeedMedia, InstaStoryFeedMediaResponse>
{
	public InstaStoryFeedMediaResponse SourceObject { get; set; }

	public InstaStoryFeedMedia Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaStoryFeedMedia
		{
			Height = SourceObject.Height,
			IsPinned = SourceObject.IsPinned,
			MediaId = SourceObject.MediaId,
			ProductType = SourceObject.ProductType,
			Rotation = SourceObject.Rotation,
			Width = SourceObject.Width,
			X = SourceObject.X,
			Y = SourceObject.Y,
			Z = SourceObject.Z
		};
	}
}
