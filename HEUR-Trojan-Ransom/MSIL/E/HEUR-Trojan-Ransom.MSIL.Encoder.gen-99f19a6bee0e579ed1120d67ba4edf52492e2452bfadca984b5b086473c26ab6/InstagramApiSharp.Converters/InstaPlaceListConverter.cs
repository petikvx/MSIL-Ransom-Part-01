using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaPlaceListConverter : IObjectConverter<InstaPlaceList, InstaPlaceListResponse>
{
	public InstaPlaceListResponse SourceObject { get; set; }

	public InstaPlaceList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaPlaceList instaPlaceList = new InstaPlaceList
		{
			HasMore = SourceObject.HasMore.GetValueOrDefault(),
			RankToken = SourceObject.RankToken,
			Status = SourceObject.Status
		};
		if (SourceObject.Items != null && SourceObject.Items.Any())
		{
			foreach (InstaPlaceResponse item in SourceObject.Items)
			{
				try
				{
					instaPlaceList.Items.Add(ConvertersFabric.Instance.GetPlaceConverter(item).Convert());
				}
				catch
				{
				}
			}
			instaPlaceList.ExcludeList = SourceObject.ExcludeList;
		}
		return instaPlaceList;
	}
}
