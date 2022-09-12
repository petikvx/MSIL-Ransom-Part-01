using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaSuggestionItemConverter : IObjectConverter<InstaSuggestionItem, InstaSuggestionItemResponse>
{
	public InstaSuggestionItemResponse SourceObject { get; set; }

	public InstaSuggestionItem Convert()
	{
		InstaSuggestionItem instaSuggestionItem = new InstaSuggestionItem
		{
			Caption = (SourceObject.Caption ?? string.Empty),
			IsNewSuggestion = SourceObject.IsNewSuggestion,
			SocialContext = (SourceObject.SocialContext ?? string.Empty),
			User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert(),
			Algorithm = (SourceObject.Algorithm ?? string.Empty),
			Icon = (SourceObject.Icon ?? string.Empty),
			Value = SourceObject.Value.GetValueOrDefault(),
			Uuid = SourceObject.Uuid
		};
		try
		{
			if (SourceObject.LargeUrls != null)
			{
				string[] largeUrls = SourceObject.LargeUrls;
				if (largeUrls != null && largeUrls.Length != 0)
				{
					string[] largeUrls2 = SourceObject.LargeUrls;
					foreach (string item in largeUrls2)
					{
						instaSuggestionItem.LargeUrls.Add(item);
					}
				}
			}
			if (SourceObject.MediaIds != null)
			{
				string[] mediaIds = SourceObject.MediaIds;
				if (mediaIds != null && mediaIds.Length != 0)
				{
					string[] largeUrls2 = SourceObject.MediaIds;
					foreach (string item2 in largeUrls2)
					{
						instaSuggestionItem.MediaIds.Add(item2);
					}
				}
			}
			if (SourceObject.ThumbnailUrls != null)
			{
				string[] thumbnailUrls = SourceObject.ThumbnailUrls;
				if (thumbnailUrls != null && thumbnailUrls.Length != 0)
				{
					string[] largeUrls2 = SourceObject.ThumbnailUrls;
					foreach (string item3 in largeUrls2)
					{
						instaSuggestionItem.ThumbnailUrls.Add(item3);
					}
				}
			}
			if (SourceObject.MediaInfos != null)
			{
				List<InstaMediaItemResponse> mediaInfos = SourceObject.MediaInfos;
				if (mediaInfos != null && mediaInfos.Count > 0)
				{
					foreach (InstaMediaItemResponse mediaInfo in SourceObject.MediaInfos)
					{
						try
						{
							InstaMedia item4 = ConvertersFabric.Instance.GetSingleMediaConverter(mediaInfo).Convert();
							instaSuggestionItem.MediaInfos.Add(item4);
						}
						catch
						{
						}
					}
					return instaSuggestionItem;
				}
				return instaSuggestionItem;
			}
			return instaSuggestionItem;
		}
		catch
		{
			return instaSuggestionItem;
		}
	}
}
