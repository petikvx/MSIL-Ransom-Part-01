using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaReelMentionConverter : IObjectConverter<InstaReelMention, InstaReelMentionResponse>
{
	public InstaReelMentionResponse SourceObject { get; set; }

	public InstaReelMention Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaReelMention instaReelMention = new InstaReelMention
		{
			Height = SourceObject.Height,
			IsPinned = System.Convert.ToBoolean(SourceObject.IsPinned),
			IsHidden = System.Convert.ToBoolean(SourceObject.IsHidden),
			Rotation = SourceObject.Rotation,
			Width = SourceObject.Width,
			X = SourceObject.X,
			Y = SourceObject.Y,
			Z = SourceObject.Z
		};
		if (SourceObject.Hashtag != null)
		{
			instaReelMention.Hashtag = ConvertersFabric.Instance.GetHashTagConverter(SourceObject.Hashtag).Convert();
		}
		if (SourceObject.User != null)
		{
			instaReelMention.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert();
		}
		return instaReelMention;
	}
}
