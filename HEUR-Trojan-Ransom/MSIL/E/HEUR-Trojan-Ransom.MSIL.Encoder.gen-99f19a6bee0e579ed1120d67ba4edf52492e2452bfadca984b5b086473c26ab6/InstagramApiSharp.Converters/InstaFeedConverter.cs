using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaFeedConverter : IObjectConverter<InstaFeed, InstaFeedResponse>
{
	public InstaFeedResponse SourceObject { get; set; }

	public InstaFeed Convert()
	{
		if (SourceObject?.Items == null)
		{
			throw new ArgumentNullException("InstaFeedResponse or its Items");
		}
		InstaFeed instaFeed = new InstaFeed();
		foreach (InstaMediaItemResponse item3 in SourceObject.Items)
		{
			if (item3 != null && item3.Type == 0)
			{
				InstaMedia item = ConvertersFabric.Instance.GetSingleMediaConverter(item3).Convert();
				instaFeed.Medias.Add(item);
			}
		}
		foreach (InstaSuggestionItemResponse suggestedUser in SourceObject.SuggestedUsers)
		{
			try
			{
				InstaSuggestionItem item2 = ConvertersFabric.Instance.GetSuggestionItemConverter(suggestedUser).Convert();
				instaFeed.SuggestedUserItems.Add(item2);
			}
			catch
			{
			}
		}
		instaFeed.NextMaxId = SourceObject.NextMaxId;
		return instaFeed;
	}
}
