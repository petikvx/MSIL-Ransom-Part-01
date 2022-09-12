using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters;

internal class InstaVoiceMediaConverter : IObjectConverter<InstaVoiceMedia, InstaVoiceMediaResponse>
{
	public InstaVoiceMediaResponse SourceObject { get; set; }

	public InstaVoiceMedia Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaVoiceMedia instaVoiceMedia = new InstaVoiceMedia
		{
			ReplayExpiringAtUs = SourceObject.ReplayExpiringAtUs,
			SeenCount = SourceObject.SeenCount.GetValueOrDefault()
		};
		if (!string.IsNullOrEmpty(SourceObject.ViewMode))
		{
			try
			{
				instaVoiceMedia.ViewMode = (InstaViewMode)Enum.Parse(typeof(InstaViewMode), SourceObject.ViewMode, ignoreCase: true);
			}
			catch
			{
			}
		}
		if (SourceObject.SeenUserIds != null)
		{
			long[] seenUserIds = SourceObject.SeenUserIds;
			if (seenUserIds != null && seenUserIds.Length != 0)
			{
				long[] seenUserIds2 = SourceObject.SeenUserIds;
				foreach (long item in seenUserIds2)
				{
					instaVoiceMedia.SeenUserIds.Add(item);
				}
			}
		}
		if (SourceObject.Media != null)
		{
			instaVoiceMedia.Media = ConvertersFabric.Instance.GetVoiceConverter(SourceObject.Media).Convert();
		}
		return instaVoiceMedia;
	}
}
