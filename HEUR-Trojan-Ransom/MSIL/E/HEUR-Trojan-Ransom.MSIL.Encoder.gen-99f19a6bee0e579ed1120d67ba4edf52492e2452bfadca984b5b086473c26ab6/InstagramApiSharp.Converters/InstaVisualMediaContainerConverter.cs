using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaVisualMediaContainerConverter : IObjectConverter<InstaVisualMediaContainer, InstaVisualMediaContainerResponse>
{
	public InstaVisualMediaContainerResponse SourceObject { get; set; }

	public InstaVisualMediaContainer Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaVisualMediaContainer instaVisualMediaContainer = new InstaVisualMediaContainer
		{
			SeenCount = SourceObject.SeenCount.GetValueOrDefault()
		};
		if (SourceObject.UrlExpireAtSecs.HasValue)
		{
			instaVisualMediaContainer.UrlExpireAt = SourceObject.UrlExpireAtSecs.Value.FromUnixTimeSeconds();
		}
		if (SourceObject.ReplayExpiringAtUs.HasValue)
		{
			instaVisualMediaContainer.ReplayExpiringAtUs = DateTime.MinValue;
		}
		if (SourceObject.Media != null)
		{
			instaVisualMediaContainer.Media = ConvertersFabric.Instance.GetVisualMediaConverter(SourceObject.Media).Convert();
		}
		if (!string.IsNullOrEmpty(SourceObject.ViewMode))
		{
			instaVisualMediaContainer.ViewMode = (InstaViewMode)Enum.Parse(typeof(InstaViewMode), SourceObject.ViewMode, ignoreCase: true);
		}
		List<long> seenUserIds = SourceObject.SeenUserIds;
		if (seenUserIds != null && seenUserIds.Count > 0)
		{
			foreach (long seenUserId in SourceObject.SeenUserIds)
			{
				instaVisualMediaContainer.SeenUserIds.Add(seenUserId);
			}
			return instaVisualMediaContainer;
		}
		return instaVisualMediaContainer;
	}
}
