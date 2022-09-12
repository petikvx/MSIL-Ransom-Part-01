using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaDiscoverSearchResultConverter : IObjectConverter<InstaDiscoverSearchResult, InstaDiscoverSearchResultResponse>
{
	public InstaDiscoverSearchResultResponse SourceObject { get; set; }

	public InstaDiscoverSearchResult Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaDiscoverSearchResult instaDiscoverSearchResult = new InstaDiscoverSearchResult
		{
			HasMoreAvailable = SourceObject.HasMore.GetValueOrDefault(),
			RankToken = SourceObject.RankToken,
			NumResults = SourceObject.NumResults.GetValueOrDefault()
		};
		if (SourceObject.Users != null && SourceObject.Users.Any())
		{
			foreach (InstaUserResponse user in SourceObject.Users)
			{
				try
				{
					instaDiscoverSearchResult.Users.Add(ConvertersFabric.Instance.GetUserConverter(user).Convert());
				}
				catch
				{
				}
			}
			return instaDiscoverSearchResult;
		}
		return instaDiscoverSearchResult;
	}
}
