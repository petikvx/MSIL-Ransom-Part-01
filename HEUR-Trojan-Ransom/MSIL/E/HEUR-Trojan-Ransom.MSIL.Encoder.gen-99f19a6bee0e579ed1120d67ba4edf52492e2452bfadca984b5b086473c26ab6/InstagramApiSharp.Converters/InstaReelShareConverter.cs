using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaReelShareConverter : IObjectConverter<InstaReelShare, InstaReelShareResponse>
{
	public InstaReelShareResponse SourceObject { get; set; }

	public InstaReelShare Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaReelShare instaReelShare = new InstaReelShare
		{
			IsReelPersisted = SourceObject.IsReelPersisted.GetValueOrDefault(),
			ReelOwnerId = SourceObject.ReelOwnerId,
			ReelType = SourceObject.ReelType,
			Text = SourceObject.Text,
			Type = SourceObject.Type
		};
		try
		{
			instaReelShare.Media = ConvertersFabric.Instance.GetStoryItemConverter(SourceObject.Media).Convert();
			return instaReelShare;
		}
		catch
		{
			return instaReelShare;
		}
	}
}
