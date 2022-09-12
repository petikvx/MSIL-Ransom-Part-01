using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaProductMediaListConverter : IObjectConverter<InstaProductMediaList, InstaProductMediaListResponse>
{
	public InstaProductMediaListResponse SourceObject { get; set; }

	public InstaProductMediaList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaProductMediaList instaProductMediaList = new InstaProductMediaList
		{
			AutoLoadMoreEnabled = SourceObject.AutoLoadMoreEnabled,
			MoreAvailable = SourceObject.MoreAvailable,
			NextMaxId = SourceObject.NextMaxId,
			ResultsCount = SourceObject.ResultsCount,
			TotalCount = SourceObject.TotalCount
		};
		if (SourceObject.Medias != null && SourceObject.Medias.Any())
		{
			foreach (InstaMediaItemResponse media in SourceObject.Medias)
			{
				instaProductMediaList.Medias.Add(ConvertersFabric.Instance.GetSingleMediaConverter(media).Convert());
			}
			return instaProductMediaList;
		}
		return instaProductMediaList;
	}
}
