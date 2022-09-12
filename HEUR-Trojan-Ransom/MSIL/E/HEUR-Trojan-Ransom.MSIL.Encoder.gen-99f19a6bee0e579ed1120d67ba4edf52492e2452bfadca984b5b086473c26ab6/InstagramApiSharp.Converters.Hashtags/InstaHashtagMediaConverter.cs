using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Hashtags;

internal class InstaHashtagMediaConverter : IObjectConverter<InstaSectionMedia, InstaSectionMediaListResponse>
{
	public InstaSectionMediaListResponse SourceObject { get; set; }

	public InstaSectionMedia Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaSectionMedia instaSectionMedia = new InstaSectionMedia
		{
			AutoLoadMoreEnabled = SourceObject.AutoLoadMoreEnabled.GetValueOrDefault(),
			MoreAvailable = SourceObject.MoreAvailable,
			NextMaxId = SourceObject.NextMaxId,
			NextMediaIds = SourceObject.NextMediaIds,
			NextPage = SourceObject.NextPage.GetValueOrDefault()
		};
		if (SourceObject.Sections != null)
		{
			foreach (InstaSectionMediaResponse section in SourceObject.Sections)
			{
				try
				{
					foreach (InstaMediaAlbumResponse media in section.LayoutContent.Medias)
					{
						try
						{
							instaSectionMedia.Medias.Add(ConvertersFabric.Instance.GetSingleMediaConverter(media.Media).Convert());
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
		}
		List<InstaPersistentSectionResponse> persistentSections = SourceObject.PersistentSections;
		if (persistentSections != null && persistentSections.Count > 0)
		{
			try
			{
				foreach (InstaPersistentSectionResponse persistentSection in SourceObject.PersistentSections)
				{
					InstaPersistentSectionLayoutContentResponse layoutContent = persistentSection.LayoutContent;
					if (layoutContent != null && layoutContent.Related?.Count > 0)
					{
						foreach (InstaRelatedHashtagResponse item in persistentSection.LayoutContent.Related)
						{
							try
							{
								instaSectionMedia.RelatedHashtags.Add(ConvertersFabric.Instance.GetRelatedHashtagConverter(item).Convert());
							}
							catch
							{
							}
						}
					}
				}
				return instaSectionMedia;
			}
			catch
			{
				return instaSectionMedia;
			}
		}
		return instaSectionMedia;
	}
}
