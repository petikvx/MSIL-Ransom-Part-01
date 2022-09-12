using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryCountdownListConverter : IObjectConverter<InstaStoryCountdownList, InstaStoryCountdownListResponse>
{
	public InstaStoryCountdownListResponse SourceObject { get; set; }

	public InstaStoryCountdownList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryCountdownList instaStoryCountdownList = new InstaStoryCountdownList
		{
			MoreAvailable = SourceObject.MoreAvailable.GetValueOrDefault(),
			MaxId = SourceObject.MaxId
		};
		List<InstaStoryCountdownStickerItemResponse> items = SourceObject.Items;
		if (items != null && items.Count > 0)
		{
			foreach (InstaStoryCountdownStickerItemResponse item in SourceObject.Items)
			{
				instaStoryCountdownList.Items.Add(ConvertersFabric.Instance.GetStoryCountdownStickerItemConverter(item).Convert());
			}
			return instaStoryCountdownList;
		}
		return instaStoryCountdownList;
	}
}
